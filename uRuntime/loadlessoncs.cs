using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using User;

namespace Source.Routines
{
    public static class u_LessonRoutines
    {
        public const char s_sp = '\\';
        public const string s_true = "True";
        public const string s_false = "False";
        public const string s_empty = "empty";

        public static class lesson
        {
            public static void AddHash(string s_hash)
            {
                string[] s_hashpool = new string[u_Project.lesson.content.s_lessons .Length+ 1];
                for (int i_index = 0; i_index < u_Project.lesson.content.s_lessons.Length; i_index++)
                {
                    s_hashpool[i_index] = u_Project.lesson.content.s_lessons[i_index];
                }
                s_hashpool[u_Project.lesson.content.s_lessons.Length] = s_hash;
                u_Project.lesson.content.s_lessons = s_hashpool;
            }
            public static void RemoveHash(int i_pos)
            {
                string[] s_hashpool = new string[u_Project.lesson.content.s_lessons.Length - 1];
                for (int i_index = 0,i_subindex = 0; i_subindex < u_Project.lesson.content.s_lessons.Length-1; i_index++, i_subindex++)
                {
                    if (i_subindex == i_pos)
                    {
                        i_index++;
                    }
                    s_hashpool[i_subindex] = u_Project.lesson.content.s_lessons[i_index];
                }
                u_Project.lesson.content.s_lessons  = s_hashpool;
            }
            public static bool SaveLessonHashes()
            {
                u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg);

                return u_Listhandler.writestringlist(u_Project.lesson.content.s_lessons);

            }
            public static int GetLessonIndex(string s_hash)
            {
                for (int i_index = 0; i_index < u_Project.lesson.content.s_lessons.Length; i_index++)
                {
                    if (u_Project.lesson.content.s_lessons[i_index] == s_hash) return i_index;
                }
                return -1;
            }
            public static bool LoadLessonHashes()
            {
                u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg);
                u_Project.lesson.content.s_lessons =  u_Listhandler.readstringlist();
                if (u_Project.lesson.content.s_lessons == null)
                {
                    u_Project.lesson.content.s_lessons = new string[0];
                    return false;
                }
                return true;
            }

            public static string PathGen(string s_hash)
            {
                return u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + s_hash;
            }
            public static string RenameFile(string s_hash,string s_file,string s_newname)
            {
                string s_filepath = u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + s_hash + s_sp + u_Vars.s_files;
                string[] s_split = s_file.Split('.');
                string s_newfile = s_newname+"."+s_split[s_split.Length - 1];
                if (!File.Exists(s_filepath+s_sp+ s_file)) { return null; }
                if (File.Exists(s_filepath+s_sp+ s_newfile)) { return null; }

                File.Copy(s_filepath + s_sp + s_file, s_filepath + s_sp + s_newfile);

                return s_newfile;
            }
            public static bool AddExternalFile(string s_file,bool b_replace)
            {
                string[] s_splitup = s_file.Split('\\');
                string s_filename = s_splitup[s_splitup.Length - 1].Replace(' ','_');

                string s_filepath = u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Project.lesson.o_loadedlesson.s_hash + s_sp + u_Vars.s_files;

                if (File.Exists(s_filepath + s_sp + s_filename)) {
                    if (b_replace)
                    {
                        File.Delete(s_filepath + s_sp + s_filename);
                    }
                    else
                    {
                        return false;
                    }

                }

                File.Copy(s_file, s_filepath + s_sp + s_filename);

                string[] s_files = new string[u_Project.lesson.o_loadedlesson.s_files.Length + 1];
                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    s_files[i_index] = u_Project.lesson.o_loadedlesson.s_files[i_index];
                }
                s_files[u_Project.lesson.o_loadedlesson.s_files.Length] = s_filename;
                u_Project.lesson.o_loadedlesson.s_files = s_files;

                return true;
            }
            public static bool CreateFile(string s_file,bool b_replace)
            {
                string s_filepath = u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Project.lesson.o_loadedlesson.s_hash + s_sp + u_Vars.s_files;

                if(File.Exists(s_filepath + s_sp + s_file))
                {
                    if (b_replace)
                    {
                        File.Delete(s_filepath + s_sp + s_file);
                    }
                    else
                    {
                        return false;
                    }
                }

                var v_file = File.Create(s_filepath + s_sp + s_file);
                v_file.Close();

                AddFile(s_file);

                return true;
            }
            public static void AddFile(string s_file)
            {
                string[] s_files = new string[u_Project.lesson.o_loadedlesson.s_files.Length + 1];
                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    s_files[i_index] = u_Project.lesson.o_loadedlesson.s_files[i_index];
                }
                s_files[u_Project.lesson.o_loadedlesson.s_files.Length] = s_file;
                u_Project.lesson.o_loadedlesson.s_files = s_files;
            }
            public static int GetFileIndex(string s_file) {
                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (s_file.Contains(u_Project.lesson.o_loadedlesson.s_files[i_index])) return i_index;
                }
                return -1;
            }
            public static void RemoveFile(int i_pos)
            {
                string[] s_hashpool = new string[u_Project.lesson.o_loadedlesson.s_files.Length - 1];
                for (int i_index = 0, i_subindex = 0; i_index < s_hashpool.Length; i_index++, i_subindex++)
                {
                    if (i_subindex == i_pos)
                    {
                        i_subindex++;
                    }
                    s_hashpool[i_index] = u_Project.lesson.o_loadedlesson.s_files[i_subindex];

                }
                u_Project.lesson.o_loadedlesson.s_files = s_hashpool;
            }
            public static string Create(s_Lesson o_lesson,s_Prefab o_prefab)
            {
                s_Lesson o_tmpls = o_lesson;
                string s_hash = HashGen(o_tmpls.s_subject, o_tmpls.o_date);
                string s_fpath = PathGen(s_hash);

                if (Directory.Exists(s_fpath))
                {
                    return null;
                }

                Directory.CreateDirectory(s_fpath);
                Directory.CreateDirectory(s_fpath+ s_sp+u_Vars.s_files);

                var v_file = File.Create(s_fpath + s_sp + u_Vars.lesson.content.s_contcfg);
                v_file.Close();
                v_file = File.Create(s_fpath + s_sp + u_Vars.lesson.info.s_contcfg);
                v_file.Close();

                o_tmpls.s_files = new string[o_prefab.s_fileendings.Length];
                o_tmpls.s_hash = s_hash;

                string s_prefab = u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs + s_sp;

                for (int i_index = 0; i_index < o_prefab.s_fileendings.Length; i_index++)
                {
                    o_tmpls.s_files[i_index] = o_tmpls.s_topic.Replace(" ", "_") + "." + o_prefab.s_fileendings[i_index];
                    if(File.Exists(s_prefab+"prefab." + o_prefab.s_fileendings[i_index]))
                    {
                        File.Copy(s_prefab + "prefab." + o_prefab.s_fileendings[i_index],s_fpath + s_sp + u_Vars.s_files + s_sp + o_tmpls.s_files[i_index]);
                    }
                    else
                    {
                        v_file = File.Create(s_fpath + s_sp + u_Vars.s_files + s_sp + o_tmpls.s_files[i_index]);
                        v_file.Close();
                    }          
                }

                u_Listhandler.configset(s_fpath + s_sp + u_Vars.lesson.content.s_contcfg);
                u_Listhandler.write(u_Vars.lesson.content.s_defcfg);
                u_Listhandler.writestringlist(o_tmpls.s_files);

                u_Confighandler.configset(s_fpath + s_sp + u_Vars.lesson.info.s_contcfg);
                u_Confighandler.write(u_Vars.lesson.info.s_defcfg);

                u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_isproject,o_tmpls.b_project.ToString());
                u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_topic, o_tmpls.s_topic);
                u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_subject, o_tmpls.s_subject);
                u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_date, u_Stringmanager.Stringfromdate(o_tmpls.o_date));
                return s_hash;
            }
            public static bool ValidLesson(string s_hash)
            {
                if(s_hash == null) { return false; }

                string s_path = PathGen(s_hash);
                if (!Directory.Exists(s_path)) { return false; }
                if (!Directory.Exists(s_path + s_sp + u_Vars.s_files)) { return false; }
                if(!File.Exists(s_path+s_sp+ u_Vars.lesson.content.s_contcfg)) { return false; }
                if(!File.Exists(s_path+s_sp+ u_Vars.lesson.info.s_contcfg)) { return false; }

                return true;
            }
            public static s_Lesson Load(string s_hash)
            {
                if (!ValidLesson(s_hash)) { return new s_Lesson(); }

                s_Lesson o_lesson = new s_Lesson();
                string s_path = PathGen(s_hash);

                u_Listhandler.configset(s_path + s_sp + u_Vars.lesson.content.s_contcfg);
                o_lesson.s_files = u_Listhandler.readstringlist();


                string s_isproject, s_date;

                u_Confighandler.configset(s_path + s_sp + u_Vars.lesson.info.s_contcfg);
                s_isproject = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg,u_Vars.lesson.info.s_cfg_isproject);
                s_date = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg,u_Vars.lesson.info.s_cfg_date);
                o_lesson.s_subject = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg,u_Vars.lesson.info.s_cfg_subject);
                o_lesson.s_topic = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg,u_Vars.lesson.info.s_cfg_topic);
                o_lesson.o_date = u_Stringmanager.Datefromstring(s_date);
                if(!bool.TryParse(s_isproject,out o_lesson.b_project))
                {
                    return new s_Lesson();
                }

                o_lesson.s_hash = s_hash;
                return o_lesson;
                        
            }
            public static bool Save(s_Lesson o_lesson)
            {
                if (!ValidLesson(o_lesson.s_hash)) { return false; }
  
                string s_path = PathGen(o_lesson.s_hash);

                u_Listhandler.configset(s_path + s_sp + u_Vars.lesson.content.s_contcfg);
                u_Listhandler.writestringlist(o_lesson.s_files);

                u_Confighandler.configset(s_path + s_sp + u_Vars.lesson.info.s_contcfg);
                u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_topic, o_lesson.s_topic);

                return true;
            }
            public static string HashGen(string s_subject,DateTime o_time)
            {
                string s_hash = s_subject.Replace("_","");
                s_hash = s_hash.ToLower()+"_";
                s_hash += o_time.Year.ToString();
                if (o_time.Month < 10)
                {
                    s_hash += "0"+o_time.Month.ToString();
                }
                else
                {
                    s_hash += o_time.Month.ToString();
                }
                if (o_time.Day < 10)
                {
                    s_hash += "0" + o_time.Day.ToString();
                }
                else
                {
                    s_hash += o_time.Day.ToString();
                }
                if (o_time.Hour < 10)
                {
                    s_hash += "0" + o_time.Hour.ToString();
                }
                else
                {
                    s_hash += o_time.Hour.ToString();
                }
                if (o_time.Minute < 10)
                {
                    s_hash += "0" + o_time.Minute.ToString();
                }
                else
                {
                    s_hash += o_time.Minute.ToString();
                }
                return s_hash;
            }

            public static class prefabs
            {

                private static string PathLink(string s_subject)
                {
                    return u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefablink + s_sp + s_subject + u_Vars.csubject.prefabs.s_filend;
                }
                private static string PathFile(string s_filend)
                {
                    return u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs + s_sp + s_filend + "." + s_filend;
                }
                public static void ManageFile(string s_fileend)
                {
                    string s_path = PathFile(s_fileend);
                    if (!File.Exists(s_path))
                    {
                        var v_file = File.Create(s_path);
                        v_file.Close();
                    }
                }
                public static void Create(string s_subject)
                {
                    string s_file = PathLink(s_subject);

                    if (File.Exists(s_file))
                    {
                        File.Delete(s_file);
                    }

                    var v_file = File.Create(s_file);
                    v_file.Close();

                    u_Listhandler.configset(s_file);
                    u_Listhandler.write(u_Vars.csubject.prefabs.s_defcfg);
                }
                public static void Delete(string s_subject)
                {
                    string s_file = PathLink(s_subject);

                    if (File.Exists(s_file))
                    {
                        File.Delete(s_file);
                    }

                }
                public static void Save(string s_subject,s_Prefab o_prefab)
                {
                    string s_file = PathLink(s_subject);

                    if (File.Exists(s_file))
                    {
                        u_Listhandler.configset(s_file);
                        u_Listhandler.writestringlist(o_prefab.s_fileendings);
                    } 
                }
                public static s_Prefab Load(string s_subject)
                {
                    string s_file = PathLink(s_subject);

                    if (!File.Exists(s_file))
                    {
                        Create(s_subject);
                    }
                    s_Prefab o_prefab = new s_Prefab();
                    u_Listhandler.configset(s_file);
                    o_prefab.s_fileendings = u_Listhandler.readstringlist();

                    return o_prefab;
                }

                public static void AddFileend(string s_end,ref string[] s_files)
                {
                    string[] s_hashpool = new string[s_files.Length + 1];
                    for (int i_index = 0; i_index < s_files.Length; i_index++)
                    {
                        s_hashpool[i_index] = s_files[i_index];
                    }
                    s_hashpool[s_files.Length] = s_end;
                    s_files = s_hashpool;
                }
                public static void RemoveFileend(int i_pos, ref string[] s_files)
                {
                    string[] s_hashpool = new string[s_files.Length - 1];
                    for (int i_index = 0, i_subindex = 0; i_index < s_hashpool.Length; i_index++, i_subindex++)
                    {
                        if (i_subindex == i_pos)
                        {
                            i_subindex++;
                        }
                        s_hashpool[i_index] = s_files[i_subindex];
                        
                    }
                    s_files = s_hashpool;

                }
                public static bool ValidFileend(string s_fileend, string[] s_files)
                {

                    for (int i_index = 0, i_subindex = 0; i_index < s_files.Length; i_index++, i_subindex++)
                    {
                        if(s_files[i_index] == s_fileend)
                        {
                            return false;
                        }
                    }
                    return true;

                }
            }
        }
    }
}
