using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Source;
using Source.Routines;
using User.Messager;
using System.IO;
using System.Drawing;
using User.Action;

namespace User
{
    public static class u_Manager
    {
        public static ucplesson o_lesson;
        public static ucpboard o_board;
        public static void StartProject() {
            if (InitializeSoftware())
            {
                InitializeProject();
                u_Project.pinfo.o_lastopened_temp = DateTime.Now;
                LoadLesson(u_Project.pinfo.s_lastfile);
            }
            FrontendManager();


        }
        public static void LoadProject()
        {
            RefreshProject();
            FrontendManager();
        }
        public static void RefreshProject()
        {
            InitializeProject();

        }
        public static void SuspectError()
        {
            RefreshProject();
        }


        public static void FrontendManager()
        {
            if (!u_Project.b_hooked)
            {
                ucpsettings o_action = new ucpsettings();
                o_action.Show();
                return;
            }
            if (!u_Project.b_running)
            {
                ucpsubjects o_action = new ucpsubjects();
                o_action.Show();
                return;
            }

        }

        public static bool InitializeSoftware()
        {
            if (!u_LoadRoutines.software.Loadcfg())
            {
                u_Message.Say(u_Stringsource.s_load_title[0], u_Stringsource.s_load_text[0], false);
                u_Errorhandler.calllog(u_Stringsource.s_load_text[5], u_Stringsource.s_load_title[5]);
                return false;
            }
            if (!u_LoadRoutines.software.LoadRoutes())
            {
                u_Message.Say(u_Stringsource.s_load_title[0], u_Stringsource.s_load_text[0], false);
                u_Errorhandler.calllog(u_Stringsource.s_load_text[5], u_Stringsource.s_load_title[5]);
                return false;
            }
            return true;
        }
        public static void ReadVersionFile()
        {
            if (File.Exists(Application.StartupPath + u_LoadRoutines.s_sp + u_Stringsource.s_versionfile))
            {
                StreamReader o_reader = new StreamReader(Application.StartupPath + u_LoadRoutines.s_sp + u_Stringsource.s_versionfile);
                if (o_reader != null)
                {
                    u_Project.s_version = o_reader.ReadToEnd();
                    o_reader.Close();
                }
            }
        }
        private static void InitializeProject()
        {
            bool b_error = false;
            u_Project.b_hooked = false;
            u_Project.b_running = false;


            if (!u_LoadRoutines.project.CheckProjectEx())
            {
                u_Message.Say(u_Stringsource.s_load_title[1], u_Stringsource.s_load_text[1], true);
                return;
            }

            if (!u_LoadRoutines.project.Checkvalidity())
            {
                if (u_Message.Ask(u_Stringsource.s_load_title[2], u_Stringsource.s_load_text[2]))
                {
                    u_LoadRoutines.project.Repair();
                    u_Message.Say(u_Stringsource.s_load_title[3], u_Stringsource.s_load_text[3], false);
                    InitializeProject();
                    return;
                }
                else
                {
                    u_Message.Say(u_Stringsource.s_load_title[1], u_Stringsource.s_load_text[1], true);
                    return;
                }
            }




            if (!u_LoadRoutines.project.pinfo.Loadcfg())
            {
                u_Message.Say(u_Stringsource.s_load_title[6], u_Stringsource.s_load_text[6], true);
                u_Errorhandler.calllog(
                    u_Stringsource.s_message_text[(int)u_Stringsource.e_messagelist.UCPIO].Replace("#", u_Vars.pinfo.s_projectcfg),
                    u_Stringsource.s_message_title[(int)u_Stringsource.e_messagelist.UCPIO]
                    );

                return;
            }

            u_Project.b_hooked = true;

            if (!u_LoadRoutines.project.subjects.Loadcfg())
            {
                u_Message.Say(u_Stringsource.s_load_title[10], u_Stringsource.s_load_text[10], true);
                u_Project.b_allowsedit = true;

                return;
            }


            if (!u_LessonRoutines.lesson.LoadLessonHashes())
            {
                u_Message.Say(u_Stringsource.s_load_title[11], u_Stringsource.s_load_text[11], true);
                u_Errorhandler.calllog(
                    u_Stringsource.s_message_text[(int)u_Stringsource.e_messagelist.UCPIO].Replace("#", u_Vars.lesson.content.s_contcfg),
                    u_Stringsource.s_message_title[(int)u_Stringsource.e_messagelist.UCPIO]
                    );
                b_error = true;
            }

            if (!u_AppointsRoutines.LoadAppointHashes())
            {
                u_Message.Say(u_Stringsource.s_load_title[11], u_Stringsource.s_load_text[11], true);
                u_Errorhandler.calllog(
                    u_Stringsource.s_message_text[(int)u_Stringsource.e_messagelist.UCPIO].Replace("#", u_Vars.appointments.s_contcfg),
                    u_Stringsource.s_message_title[(int)u_Stringsource.e_messagelist.UCPIO]
                    );
                b_error = true;
            }

            if (b_error == true)
            {
                return;
            }

            u_Project.b_running = true;

            if (u_Project.lesson.content.s_lessons.Length == 0)
            {
                u_Project.b_allowsedit = true;
            }
            else
            {
                u_Project.b_allowsedit = false;
            }

        }
        public static int LessonFileIndex(string s_File)
        {
            return u_LessonRoutines.lesson.GetFileIndex(s_File) ;
        
        }
        public static void AddHash(string s_hash) {
            u_LessonRoutines.lesson.AddHash(s_hash);
            u_LessonRoutines.lesson.SaveLessonHashes();
        }
        public static bool DeleteLesson(string s_hash)
        {
            if (u_Message.Ask(u_Stringsource.s_load_title[19], u_Stringsource.s_load_text[19]))
            {
                u_LessonRoutines.lesson.RemoveHash(u_LessonRoutines.lesson.GetLessonIndex(s_hash));
                u_LessonRoutines.lesson.SaveLessonHashes();
                CloseLesson();
                return true;
            }
            return false;
        }
        public static string CreateLesson(s_Lesson o_lesson, s_Prefab o_prefab)
        {
            string s_hash = u_LessonRoutines.lesson.Create(o_lesson, o_prefab);
            if (s_hash == null)
            {
                return null;
            }
            u_LessonRoutines.lesson.AddHash(s_hash);
            u_LessonRoutines.lesson.SaveLessonHashes();
            return s_hash;
        }
        public static bool CreateAppoint(s_Appointment o_appoint)
        {
            return u_AppointsRoutines.CreateAppoint(o_appoint);
        }
        public static void SaveAppointText(string s_hash, string s_text)
        {
            u_AppointsRoutines.SaveAppoint(s_hash, s_text);
        }

        public static s_Lesson GetLesson(string s_hash)
        {
            return u_LessonRoutines.lesson.Load(s_hash);
        }

        public static s_Appointment GetAppoint(string s_hash)
        {
            return u_AppointsRoutines.LoadAppoint(s_hash);
        }
        public static void DeleteAppoint(string s_hash)
        {
            u_AppointsRoutines.DeleteAppoint(s_hash);
        }
        public static void SaveAppoint()
        {
            u_AppointsRoutines.SaveAppointHashes();
        }
        public static bool LoadLesson(string s_hash)
        {
            u_Project.lesson.o_loadedlesson = u_LessonRoutines.lesson.Load(s_hash);
            if (u_Project.lesson.o_loadedlesson.s_hash == null)
            {
                u_Project.lesson.b_access = false;
                return false;
            }

            u_Project.lesson.b_access = true;
            u_Project.pinfo.s_lastfile = s_hash;
            SaveProjectInfo();
            return true;
        }
        public static string RenameFileFromLesson(int i_index, string s_filename)
        {
            string s_newfile = u_LessonRoutines.lesson.RenameFile(u_Project.lesson.o_loadedlesson.s_hash, u_Project.lesson.o_loadedlesson.s_files[i_index], s_filename);
            u_Project.lesson.o_loadedlesson.s_files[i_index] = s_newfile;
            return s_newfile;
        }
        public static bool AddFileToLesson(string s_file) {
            string[] s_split = s_file.Split('.');
            if (s_split[s_split.Length - 1].Length > 0 && s_file.Contains('.'))
            {
                if (!u_LessonRoutines.lesson.CreateFile(s_file, false))
                {
                    if (u_Message.Ask(u_Stringsource.s_load_title[13], u_Stringsource.s_load_text[13]))
                    {
                        int i_pos = u_LessonRoutines.lesson.GetFileIndex(s_file);
                        if (i_pos > -1)
                        {
                            RemoveFileFromLesson(i_pos);
                        }
                        u_LessonRoutines.lesson.CreateFile(s_file, true);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                u_Message.Say(u_Stringsource.s_load_title[14], u_Stringsource.s_load_text[14], true);

            }
            return true;
        }
        public static void AddFileToLessonByName(string s_file)
        {
            u_LessonRoutines.lesson.AddFile(s_file);
        }
        public static void AddExternFileToLesson(string s_newfile)
        {
            if (!u_LessonRoutines.lesson.AddExternalFile(s_newfile, false))
            {
                if (u_Message.Ask(u_Stringsource.s_load_title[13], u_Stringsource.s_load_text[13]))
                {
                    u_LessonRoutines.lesson.AddExternalFile(s_newfile, true);
                }

            }
        }
        public static bool RemoveNonFileFromLesson(int i_missing)
        {
            if (u_Message.Ask(u_Stringsource.s_load_title[15], u_Stringsource.s_load_text[15].Replace("#", i_missing.ToString())))
            {

                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (!File.Exists(GetFileLessonPath(u_Project.lesson.o_loadedlesson.s_hash) + u_Project.lesson.o_loadedlesson.s_files[i_index]))
                    {
                        u_LessonRoutines.lesson.RemoveFile(i_index);
                        i_index--;
                    }
                }
                return true;
            }
            return false;
        }
        public static string GetLessonPath(string s_hash)
        {
            return u_Project.software.s_projectfolder +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_data +
                    u_LoadRoutines.s_sp +
                    s_hash+ u_LoadRoutines.s_sp;
        }
        public static string GetFileLessonPath(string s_hash)
        {
            return u_Project.software.s_projectfolder +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_data +
                    u_LoadRoutines.s_sp +
                    s_hash + 
                    u_LoadRoutines.s_sp+
                    u_Vars.s_files +
                    u_LoadRoutines.s_sp;
        }
        public static void RemoveFileFromLesson(int i_index)
        {
            u_LessonRoutines.lesson.RemoveFile(i_index);
        }
        public static void Create(string s_root)
        {
            u_LoadRoutines.project.Create(s_root);
            Addroute(s_root);
        }
        public static void Addroute(string s_root)
        {
            u_LoadRoutines.software.AddRoute(s_root);
        }
        public static void RemoveRoute(int i_root)
        {
            u_LoadRoutines.software.RemRoute(i_root);
        }

        public static void SaveSubjects()
        {
            if (!u_LoadRoutines.project.subjects.Savecfg())
            {
                u_Message.Say(u_Stringsource.s_load_title[10], u_Stringsource.s_load_text[10], false);
            }
        }
        public static void SaveProjectInfo()
        {
            u_LoadRoutines.project.pinfo.Savecfg();
        }
        public static void SaveProjectCfg()
        {
            if (u_LoadRoutines.software.Setcfg())
            {
                return;
            }
            else {
                u_Project.b_hooked = false;
                u_Message.Say(u_Stringsource.s_load_title[4], u_Stringsource.s_load_text[4], false);
                if (u_LoadRoutines.software.Setcfg())
                {
                    LoadProject();
                }
            }
        }
        public static bool LoadOpenLesson(string s_hash)
        {
            if (LoadLesson(s_hash) != true)
            {
                return false;
            }
            return true;
        }
        public static void CloseLesson()
        {
            if (o_lesson != null) {
                o_lesson.Close();
                o_lesson.Dispose();
                u_Project.lesson.b_access = false;
                u_Project.pinfo.s_lastfile = "empty";
                SaveProjectInfo();
                u_Manager.RefreshProject();
            }
        }

        public static void OpenLesson(string s_hash)
        {
            if (LoadLesson(s_hash) != true)
            {
                u_Message.Say(u_Stringsource.s_load_title[12], u_Stringsource.s_load_text[12],true);
                return;
            }

            o_board.ShowLesson();

            //if (o_lesson != null)
            //{
            //     o_lesson.Dispose();
            //}
            //o_lesson = new ucplesson();

            //Rectangle o_res = Screen.PrimaryScreen.WorkingArea;
            //Point o_pos =  new Point(o_res.Width- o_lesson.Width, o_res.Height - o_lesson.Height );
            //o_lesson.Show();
            //o_lesson.Location = o_pos;
            
        }


        public static s_Prefab LoadPrefab(string s_subject)
        {
            return u_LessonRoutines.lesson.prefabs.Load(s_subject);
        }

        public static void ManagePrefabFiles()
        {
            for (int i_index = 0; i_index < u_Project.prefab.o_current.s_fileendings.Length; i_index++)
            {
                u_LessonRoutines.lesson.prefabs.ManageFile(u_Project.prefab.o_current.s_fileendings[i_index]);
            }
        }

        public static void SavePrefab(string s_subject,s_Prefab o_prefab)
        {
            u_LessonRoutines.lesson.prefabs.Save(s_subject, o_prefab);
        }

        public static bool ValidPrefabFilend(string s_fileend, string[] s_files)
        {
            return u_LessonRoutines.lesson.prefabs.ValidFileend(s_fileend, s_files);
        }
        public static void AddPrefabFilend(string s_end, ref string[] s_files)
        {
            u_LessonRoutines.lesson.prefabs.AddFileend(s_end, ref s_files);
        }
        public static void RemovePrefabFilend(int i_pos, ref string[] s_files)
        {
            u_LessonRoutines.lesson.prefabs.RemoveFileend(i_pos, ref s_files);
        }
        public static string GetFilePathFromIndex(int i_index)
        {
            return GetFilePathFromString(u_Project.lesson.o_loadedlesson.s_files[i_index]);
        }
        public static string GetFilePathFromString(string s_file)
        {
            return u_Project.software.s_projectfolder +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_data +
                    u_LoadRoutines.s_sp +
                    u_Project.lesson.o_loadedlesson.s_hash +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_files +
                    u_LoadRoutines.s_sp + s_file;
        }
    }
}
