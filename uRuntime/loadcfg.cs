using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Source;
using User;

namespace Source.Routines
{

    public static class u_LoadRoutines
    {
        public const char s_sp = '\\';
        public const string s_true = "True";
        public const string s_false = "False";
        public const string s_empty = "empty";

        public static class project {

            public static void Create(string s_root) {
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_data);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_table);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefablink);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_homework);
                Directory.CreateDirectory(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_appointments);

                var v_file = File.Create(s_root + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg);
                v_file.Close();
                v_file = File.Create(s_root + s_sp + u_Vars.pinfo.s_projectcfg);
                v_file.Close();
                v_file = File.Create(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg);
                v_file.Close();
                v_file = File.Create(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.routelist.s_contcfg);
                v_file.Close();

                u_Confighandler.configset(s_root + s_sp + u_Vars.pinfo.s_projectcfg);
                u_Confighandler.write(u_Vars.pinfo.s_defcfg);

                u_Listhandler.configset(s_root + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg);
                u_Listhandler.write(u_Vars.lesson.content.s_defcfg);
                u_Listhandler.configset(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg);
                u_Listhandler.write(u_Vars.csubject.s_defcfg);
                u_Listhandler.configset(s_root + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg);
                u_Listhandler.write(u_Vars.appointments.s_deflst);

                u_Project.software.s_projectfolder = s_root;

                u_Project.pinfo.s_ctimetable = s_empty;
                u_Project.pinfo.s_grade = s_empty;
                u_Project.pinfo.s_lastfile = s_empty;

                u_Project.pinfo.o_createdon = DateTime.Now;
                u_Project.pinfo.o_lastopened = DateTime.Now;

                pinfo.Savecfg();
            }
            public static void Repair() {


                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_table))
                {
                    Directory.CreateDirectory(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_table);
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefablink))
                {
                    Directory.CreateDirectory(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefablink);
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs))
                {
                    Directory.CreateDirectory(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs);
                }


                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg))
                {
                    u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp + u_Vars.lesson.content.s_contcfg);
                    u_Listhandler.write(u_Vars.lesson.content.s_defcfg);
                }
                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg))
                {
                    u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg);
                    u_Listhandler.write(u_Vars.appointments.s_deflst);
                }
                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg))
                {
                    u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg);
                    u_Listhandler.write(u_Vars.csubject.s_defcfg);
                }
            }
            public static bool CheckProjectEx()
            {

                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.pinfo.s_projectcfg))
                {
                    return false;
                }

                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources))
                {
                    return false;
                }

                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data))
                {
                    return false;
                }
                return true;
            }
            public static bool Checkvalidity()
            {


                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg))
                {
                    return false;
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_table))
                {
                    return false;
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefablink))
                {
                    return false;
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_prefabs))
                {
                    return false;
                }
                if (!Directory.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data))
                {
                    return false;
                }
                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_data + s_sp +u_Vars.lesson.content.s_contcfg))
                {
                    return false;
                }
                if (!File.Exists(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg))
                {
                    return false;
                }
                return true;
            }
            public static class subjects
            {
                public static bool Loadcfg()
                {
                    u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp +u_Vars.s_resources+s_sp+u_Vars.csubject.s_subjectcfg);
                    u_Project.subjects.s_subjects = u_Listhandler.readstringlist();
                    if (u_Project.subjects.s_subjects == null) {
                        u_Listhandler.write(u_Vars.csubject.s_defcfg);
                        u_Project.subjects.s_subjects = u_Listhandler.readstringlist();
                        return false;
                    }
                    if (u_Project.subjects.s_subjects.Length < 1) {
                        return false;
                    }
                    return true;
                }
                public static bool Savecfg()
                {
                    u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.csubject.s_subjectcfg);
                    if (!u_Listhandler.writestringlist(u_Project.subjects.s_subjects)) {
                        u_Listhandler.write(u_Vars.csubject.s_defcfg);
                        u_Listhandler.writestringlist(u_Project.subjects.s_subjects);
                        return false;
                    }
                    return true;
                }
            }
            public static class pinfo
            {
                public static bool Loadcfg() {
                    string s_ctimetable, s_grade, s_createdon, s_lastopened,s_lastfile,s_remindme;

                    u_Confighandler.configset(u_Project.software.s_projectfolder+s_sp+u_Vars.pinfo.s_projectcfg);

                    s_ctimetable = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_timetable);
                    s_lastfile = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_lastsession);
                    s_lastopened = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_lastopended);
                    s_grade = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_grade);
                    s_createdon = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_createdate);
                    s_remindme = u_Confighandler.readstring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_remindme);


                    if(!bool.TryParse(s_remindme,out u_Project.pinfo.b_remindme))
                    {
                        return false;
                    }

                    if (s_ctimetable == null || s_grade == null || s_createdon == null || s_lastopened == null || s_lastfile == null)
                    {
                        return false;
                    }

                    u_Project.pinfo.s_ctimetable = s_ctimetable;
                    u_Project.pinfo.s_grade = s_grade; 
                    u_Project.pinfo.s_lastfile = s_lastfile;               

                    u_Project.pinfo.o_createdon = u_Stringmanager.Datefromstring(s_createdon); 
                    u_Project.pinfo.o_lastopened = u_Stringmanager.Datefromstring(s_lastopened);


                    return true;

                }

                public static void Savecfg()
                {
                    u_Confighandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.pinfo.s_projectcfg);

                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_timetable, u_Project.pinfo.s_ctimetable);
                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_lastsession, u_Project.pinfo.s_lastfile);
                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_lastopended, u_Stringmanager.Stringfromdate(u_Project.pinfo.o_lastopened));
                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_grade, u_Project.pinfo.s_grade);
                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_createdate, u_Stringmanager.Stringfromdate(u_Project.pinfo.o_createdon));            
                    u_Confighandler.writestring(u_Vars.pinfo.s_cfgreg, u_Vars.pinfo.s_cfg_remindme, u_Project.pinfo.b_remindme.ToString());            

                }
            }
        }

        public static class software
        {


            public static bool LoadRoutes()
            {

                u_Listhandler.configset(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg);

                if (!File.Exists(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg))
                {
                    u_Listhandler.write(u_Vars.routelist.s_defcfg);
                    return false;
                }
                u_Project.software.s_projectroutes = u_Listhandler.readstringlist();
                return  true;

            }
            public static bool Saveroutes()
            {
                u_Listhandler.configset(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg);

                if (!File.Exists(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg))
                {
                    u_Listhandler.write(u_Vars.routelist.s_defcfg);
                    return false;
                }
                u_Listhandler.writestringlist(u_Project.software.s_projectroutes);
                return true;
            }
            public static void AddRoute(string s_Path)
            {
                string[] s_hashpool = new string[u_Project.software.s_projectroutes.Length + 1];
                for (int i_index = 0; i_index < u_Project.software.s_projectroutes.Length; i_index++)
                {
                    s_hashpool[i_index] = u_Project.software.s_projectroutes[i_index];
                }
                s_hashpool[u_Project.software.s_projectroutes.Length] = s_Path;
                u_Project.software.s_projectroutes = s_hashpool;
                Saveroutes();
            }
            public static void RemRoute(int i_Pos)
            {
                string[] s_hashpool = new string[u_Project.software.s_projectroutes.Length - 1];
                for (int i_index = 0, i_subindex = 0; i_subindex < u_Project.software.s_projectroutes.Length - 1; i_index++, i_subindex++)
                {
                    if (i_subindex == i_Pos)
                    {
                        i_index++;
                    }
                    s_hashpool[i_subindex] = u_Project.software.s_projectroutes[i_index];
                }
                u_Project.software.s_projectroutes = s_hashpool;
                Saveroutes();

            }
            public static bool Loadcfg()
            {
                string s_ldproject, s_automst, s_smartst, s_ploaded;

                if (!File.Exists(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg))
                {
                    u_Confighandler.configset(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg);
                    u_Confighandler.write(u_Vars.route.s_defcfg);
                    return false;
                }

                if (!File.Exists(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg))
                {
                    u_Listhandler.configset(Application.StartupPath + s_sp + u_Vars.routelist.s_contcfg);
                    u_Listhandler.write(u_Vars.routelist.s_defcfg);
                    return false;
                }


                u_Confighandler.configset(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg);

                s_ldproject = u_Confighandler.readstring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_loadedproject);
                s_automst = u_Confighandler.readstring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_autostart);
                s_smartst = u_Confighandler.readstring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_smartstart);
                s_ploaded = u_Confighandler.readstring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_ploaded);

                if (s_ldproject == null || s_automst == null || s_smartst == null || s_ploaded == null)
                {
                    File.Delete(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg);
                    return false;
                }

                if (s_automst != s_false && s_automst != s_true)
                {
                    return false;
                }
                if (s_smartst != s_false && s_smartst != s_true)
                {
                    return false;
                }
                if (s_ploaded != s_false && s_ploaded != s_true)
                {
                    return false;
                }

                u_Project.software.s_projectfolder = s_ldproject;
                u_Project.software.b_autostart = bool.Parse(s_automst);
                u_Project.software.b_smartstart = bool.Parse(s_smartst);
                u_Project.software.b_ploaded = bool.Parse(s_ploaded);

                if (!u_Project.software.b_ploaded)
                {
                    return false;
                }

                return true;
            }

            public static bool Setcfg()
            {
                if (!File.Exists(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg))
                {
                    u_Confighandler.configset(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg);

                    u_Confighandler.write(u_Vars.route.s_defcfg);
                    return false;
                }

                u_Confighandler.configset(Application.StartupPath + s_sp + u_Vars.route.s_softwarecfg);

                u_Confighandler.writestring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_loadedproject, u_Project.software.s_projectfolder);
                u_Confighandler.writestring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_autostart, u_Project.software.b_autostart.ToString());
                u_Confighandler.writestring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_smartstart, u_Project.software.b_smartstart.ToString());
                u_Confighandler.writestring(u_Vars.route.s_cfgreg, u_Vars.route.s_cfg_ploaded, u_Project.software.b_ploaded.ToString());
                return true;

            }
        }
    }
}
