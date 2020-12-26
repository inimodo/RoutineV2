using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public static class u_Project
    {
        public static bool b_hooked = false;
        public static bool b_running = false;
        public static bool b_ttloaded = false;
        public static bool b_allowsedit = false;

        public static string s_version="none";

        public const string s_empty = "empty";
        public static class software
        {
            public static string[] s_projectroutes = new string[0];
            public static string s_projectfolder = "";
            public static bool b_autostart = false;
            public static bool b_smartstart = false;
            public static bool b_ploaded = false;
        }
        public static class user
        {
            private static string s_username_;
            private static string s_usercode_;
            private static bool b_loggedin_;

            public static string s_username { get { return s_username_; } }
            public static string s_usercode { get { return s_usercode_; } }
            public static bool b_loggedin { get { return b_loggedin_; } }

            public static void Senduser(string s_name, string s_code, bool b_in)
            {
                s_username_ = s_name;
                s_usercode_ = s_code;
                b_loggedin_ = b_in;
            }
        }
        public static class pinfo
        {
            public static string s_ctimetable = "empty";
            public static string s_grade = "empty";
            public static DateTime o_createdon;
            public static DateTime o_lastopened;
            public static DateTime o_lastopened_temp;
            public static bool b_remindme = false;
            public static string s_lastfile = "empty";
        }
        public static class subjects
        {
            public static string[] s_subjects = new string[0];
        }
        public static class lesson
        {
            public static bool b_access = false;
            public static s_Lesson o_loadedlesson;
            public static class content
            {
                public static string[] s_lessons = new string[0];
            }
        }
        public static class appointments
        {
            public static string[] s_appoints = new string[0];
        }

        public static class prefab
        {
            public static s_Prefab o_current;
            public static string s_subject;
        }
    }
    public static class u_Vars
    {
        public static string s_resources = "resources";
        public static string s_table = "table";
        public static string s_prefablink = "prefablink";
        public static string s_prefabs = "prefabs";
        public static string s_data = "data";
        public static string s_homework = "homework";
        public static string s_appointments = "appointments";
        public static string s_files = "files";
        public static string s_temp = "tmp";
        public static class routelist
        {
            public const string s_contcfg = "router.lst";
            public const string s_defcfg = "[UCFG/L]{}";

        }
        public static class route
        {
            public const string s_softwarecfg = "router.cfg";
            public const string s_cfg_loadedproject = "ldproject";
            public const string s_cfg_autostart = "automst";
            public const string s_cfg_smartstart = "smartst";
            public const string s_cfg_ploaded = "ploaded";

            public const string s_cfgreg = "settings";
            public const string s_defcfg = "[UCFG/C]{[UNIT=(settings)]{[REG=(ldproject);TYPE=(str);VALUE=(empty)],[REG=(automst);TYPE=(str);VALUE=(False)],[REG=(smartst);TYPE=(str);VALUE=(False)],[REG=(ploaded);TYPE=(str);VALUE=(False)]}}";
        }
        public static class pinfo
        {
            public const string s_projectcfg = "pinfo.ucp";
            public const string s_cfg_createdate = "cdate";
            public const string s_cfg_lastopended = "lopen";
            public const string s_cfg_grade = "grade";
            public const string s_cfg_timetable = "ctt";
            public const string s_cfg_lastsession = "lses";
            public const string s_cfg_remindme = "remme";
            public const string s_cfgreg = "settings";
            public const string s_defcfg = "[UCFG/C]{[UNIT=(settings)]{[REG=(cdate);TYPE=(str);VALUE=(empty)],[REG=(lopen);TYPE=(str);VALUE=(empty)],[REG=(grade);TYPE=(str);VALUE=(empty)],[REG=(ctt);TYPE=(str);VALUE=(empty)],[REG=(lses);TYPE=(str);VALUE=(empty)],[REG=(remme);TYPE=(str);VALUE=(False)]}}";

        }

        public static class csubject
        {
            public const string s_subjectcfg = "csubjects.lst";
            public const string s_defcfg = "[UCFG/L]{}";

            public static class prefabs
            {
                public const string s_defaultfe = "txt";

                public const string s_filend = ".lst";
                public const string s_defcfg = "[UCFG/L]{"+ s_defaultfe + "}";

            }

        }
        public static class lesson
        {
            public static class content
            {
                public const string s_contcfg = "ls_content.lst";
                public const string s_defcfg = "[UCFG/L]{}";

            }
            public static class info
            {
                public const string s_contcfg = "info.ucp";
                public const string s_defcfg = "[UCFG/C]{[UNIT=(info)]{[REG=(ispro);TYPE=(str);VALUE=(#ispro#)],[REG=(topic);TYPE=(str);VALUE=(#topic#)],[REG=(subj);TYPE=(str);VALUE=(#subj#)],[REG=(date);TYPE=(str);VALUE=(#date#)]}}";

                public const string s_cfg_isproject = "ispro";
                public const string s_cfg_topic = "topic";
                public const string s_cfg_subject = "subj";
                public const string s_cfg_date = "date";

                public const string s_cfgreg = "info";


            }
        }
        public static class appointments
        {
            public const string s_contcfg = "ap_content.lst";
            public const string s_hwcfg = "_inf.ucp";
            public const string s_textfile = "_txt.txt";

            public const string s_deflst = "[UCFG/L]{}";
            public const string s_defcfg = "[UCFG/C]{[UNIT=(info)]{[REG=(subj);TYPE=(str);VALUE=(empty)],[REG=(date);TYPE=(str);VALUE=(empty)]}}";

            public const string s_cfg_subject = "subj";
            public const string s_cfg_deadline = "date";
            public const string s_cfgreg = "info";

        }
    }

    public struct s_Lesson {
        public string[] s_files;

        public bool b_project;
        public string s_topic;
        public string s_subject;
        public DateTime o_date;

        public string s_hash;
    }
    public struct s_Prefab
    {
        public string[] s_fileendings;
    }

    public struct s_Homework
    {
        public DateTime o_deadline;
        public string s_subject;
        public string s_text;

        public string s_hash;
    }

    public struct s_Appointment
    {
        public DateTime o_date;
        public string s_subject;
        public string s_text;

        public string s_hash;
    }
}
