using System;
using System.Collections.Generic;
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

        public static void Create(string s_Path,string s_Name)
        {
            using (UniversalConfigCreator o_Creator = new UniversalConfigCreator(s_Path+"\\config.ufg"))
            {
                o_Creator.AppendUnit("DATA");
                o_Creator.AppendRegister("DATA","NAME",typeof(string));
                o_Creator.AppendRegister("DATA","SUBJECTS",typeof(string));
                o_Creator.Build();
            }
            using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + "\\config.ufg"))
            {
                o_Reader.SetValue<string>("DATA", "NAME",s_Name);
                o_Reader.SaveConfig();
            }

            Directory.CreateDirectory(s_Path+"\\Files");
            Directory.CreateDirectory(s_Path+"\\Deadlines");
            Directory.CreateDirectory(s_Path+"\\Template");
        }
        public static void Save()
        {
            string s_Path;
            if (Router.GetCurrentDir(out s_Path))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + "config.ufg"))
                {
                    o_Reader.SetArray<string>("DATA", "SUBJECTS", s_Subjects.o_Content);
                    o_Reader.SaveConfig();
                }
            }
        }
        public static void Load()
        {
            string s_Path;
            if (Router.GetCurrentDir(out s_Path))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_Path + "config.ufg"))
                {
                    o_Reader.LoadConfig();
                    s_Subjects.o_Content = o_Reader.GetAsStringArray("DATA", "SUBJECTS",typeof(string));
                }
            }
        }
    }
}
