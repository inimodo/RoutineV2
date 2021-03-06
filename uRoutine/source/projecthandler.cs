﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalConfig;
namespace User.Source
{
    public class Projecthandler
    {
        public static Lists<string> s_Subjects = new Lists<string>();
        public static string s_Name;
        public static void Create(string s_Path,string s_Name)
        {
            using (UniversalConfigCreator o_Creator = new UniversalConfigCreator(s_Path+@"\config.ufg"))
            {
                o_Creator.AppendUnit("DATA");
                o_Creator.AppendRegister("DATA","NAME",typeof(string));
                o_Creator.AppendRegister("DATA","SUBJECTS",typeof(string));
                o_Creator.Build();
            }
            using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + @"\config.ufg"))
            {
                o_Reader.SetValue<string>("DATA", "NAME",s_Name);
                o_Reader.SaveConfig();
            }

            Directory.CreateDirectory(s_Path+@"\Files");
            Directory.CreateDirectory(s_Path+@"\Deadlines");
            Directory.CreateDirectory(s_Path+@"\Template");
        }
        public static bool Save()
        {
            string s_Path;
            if (Router.GetCurrentDir(out s_Path))
            {
                if (!File.Exists(s_Path + "config.ufg")) return false;
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + "config.ufg"))
                {
                    o_Reader.SetArray<string>("DATA", "SUBJECTS", s_Subjects.o_Content);
                    o_Reader.SaveConfig();
                }
                return true;

            }
            return false;

        }
        public static bool Load()
        {
            string s_Path;
            if (Router.GetCurrentDir(out s_Path))
            {
                if (!File.Exists(s_Path + "config.ufg")) return false;
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + "config.ufg"))
                {
                    o_Reader.LoadConfig();//NOTICE
                    s_Subjects.o_Content = o_Reader.GetAsStringArray("DATA", "SUBJECTS", typeof(string));
                    s_Name = o_Reader.GetRawValue("DATA", "NAME", typeof(string));
                }
                return true;
            }
            return false;
        }
        public static class Files
        {
            public struct Session
            {
                public string s_Inheritance, s_Name,s_Subject;
                public DateTime o_Date;
            }
            public static int i_LoadedSession = -1;
            public static Lists<Session> o_Sessions = new Lists<Session>();

            public static void FetchAll()
            {
                o_Sessions.Clear();
                string s_Path;
                if (Router.GetCurrentDir(out s_Path))
                {
                    string[] s_pContent =  Directory.GetFiles(s_Path+@"\Files");
                    foreach (string s_Configfile in s_pContent)
                    {
                        if(s_Configfile.Contains(".ufg"))o_Sessions.Add(LoadConfig(s_Configfile));
                    }
                }
            }

            public static Session LoadConfig(string s_AbsPath)
            {
                Session o_NewSession = new Session();
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_AbsPath))
                {
                    o_Reader.LoadConfig();
                    o_NewSession.s_Name = o_Reader.GetRawValue("SESSION", "NAME",typeof(string));
                    o_NewSession.s_Subject = o_Reader.GetRawValue("SESSION", "SUBJECT", typeof(string));
                    o_NewSession.s_Inheritance= o_Reader.GetRawValue("SESSION", "INHERITANCE", typeof(string));
                    o_NewSession.o_Date = o_Reader.GetValue<DateTime>("SESSION", "DATE");
                }
                return o_NewSession;
            }
            public static void SaveConfig(int i_Index )
            {
                string s_Path;
                if (Router.GetCurrentDir(out s_Path))
                {
                    using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path+@"Files\"+ GetSessionName(i_Index)+".ufg"))
                    {
                        o_Reader.SetValue<string>("SESSION", "NAME", o_Sessions.o_Content[i_Index].s_Name);
                        o_Reader.SetValue<string>("SESSION", "SUBJECT", o_Sessions.o_Content[i_Index].s_Subject);
                        o_Reader.SetValue<string>("SESSION", "INHERITANCE", o_Sessions.o_Content[i_Index].s_Inheritance);
                        o_Reader.SaveConfig();
                    }
                }

            }
            public static string GetSessionPath(int i_SessionIndex )
            {
                string s_Path;
                if (Router.GetCurrentDir(out s_Path))
                {
                    return s_Path + @"Files\" + GetSessionName(i_SessionIndex) + @"\";
                }
                return null;
            }
            public static string GetSessionName(int i_SessionIndex)
            {
                return GetSessionName(Files.o_Sessions.o_Content[i_SessionIndex].s_Subject, Files.o_Sessions.o_Content[i_SessionIndex].o_Date);
            }
            public static string GetSessionName(string s_Subject,DateTime o_Date)
            {
                return s_Subject + "_" + o_Date.Year + "_" + o_Date.Month + "_" + o_Date.Day + "_" + o_Date.Hour + "_" + o_Date.Minute;
            }
            public static bool Create(Session o_Session,int[] i_Temps)
            {
                string s_Path;
                if (Router.GetCurrentDir(out s_Path))
                {
                    string s_ConfigPath = GetSessionName(o_Session.s_Subject, o_Session.o_Date);
                    Directory.CreateDirectory(s_Path + @"\Files\" + s_ConfigPath);
                    if (i_Temps != null)
                    {
                        for (int i_Index = 0; i_Index < i_Temps.Length; i_Index++)
                        {
                            string s_NewFileName = o_Session.s_Name + "." + Templates.o_Templates.o_Content[i_Temps[i_Index]].s_FileName.Split('.')[1];
                            if (!File.Exists(s_Path + @"\Files\" + s_ConfigPath + @"\" + s_NewFileName))
                            {
                                File.Copy(Templates.o_Templates.o_Content[i_Temps[i_Index]].s_Path, s_Path + @"\Files\" + s_ConfigPath + @"\" + s_NewFileName);
                            }
                        }
                    }
                    using (UniversalConfigCreator o_Creator = new UniversalConfigCreator(s_Path+@"\Files\"+s_ConfigPath + ".ufg"))
                    {
                        o_Creator.AppendUnit("SESSION");
                        o_Creator.AppendRegister("SESSION", "NAME", typeof(string));
                        o_Creator.AppendRegister("SESSION", "SUBJECT", typeof(string));
                        o_Creator.AppendRegister("SESSION", "INHERITANCE", typeof(string));
                        o_Creator.AppendRegister("SESSION", "DATE", typeof(DateTime));
                        o_Creator.Build();
                    }
                    using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + @"\Files\" + s_ConfigPath + ".ufg"))
                    {
                        o_Reader.SetValue<string>("SESSION", "NAME", o_Session.s_Name);
                        o_Reader.SetValue<string>("SESSION", "SUBJECT", o_Session.s_Subject);
                        o_Reader.SetValue<string>("SESSION", "INHERITANCE", o_Session.s_Inheritance);
                        o_Reader.SetValue<DateTime>("SESSION", "DATE", o_Session.o_Date);
                        o_Reader.SaveConfig();
                    }
                    o_Sessions.Add(o_Session);
                }
                return false;
            }
        }

        public static class Templates
        {
            public struct Template
            {
                public string s_Path, s_FileName;
                public Icon o_Icon;
            }
            public static Lists<Template> o_Templates = new Lists<Template>();
            public static void LoadTemplates()
            {
                string s_Path;
                if (Router.GetCurrentDir(out s_Path))
                {
                    string[] s_pContent = Directory.GetFiles(s_Path + "Template");
                    foreach (string s_FilePath in s_pContent)
                    {
                        Template o_FileAss = new Template();
                        o_FileAss.o_Icon = Icon.ExtractAssociatedIcon(s_FilePath);
                        o_FileAss.s_Path = s_FilePath;
                        o_FileAss.s_FileName = s_FilePath.Split('\\')[s_FilePath.Split('\\').Length - 1];
                        o_Templates.Add(o_FileAss);
                    }

                }
            }

        }
    }
}
