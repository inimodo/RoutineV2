using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using User;

namespace Source.Routines
{
    public static class u_AppointsRoutines
    {
        public const char s_sp = '\\';
        public const string s_true = "True";
        public const string s_false = "False";
        public const string s_empty = "empty";

        public static bool CreateAppoint(s_Appointment o_homework)
        {
            s_Appointment o_savehw = o_homework;
            o_homework.s_hash = HashGen(o_homework);
            string s_path = u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_appointments+s_sp;

            if(File.Exists(s_path + o_homework.s_hash + u_Vars.appointments.s_hwcfg)) { return false; }
            if(File.Exists(s_path + o_homework.s_hash + u_Vars.appointments.s_textfile)) { return false; }

            var v_file = File.Create(s_path + o_homework.s_hash + u_Vars.appointments.s_textfile);
            v_file.Close();
            v_file = File.Create(s_path + o_homework.s_hash + u_Vars.appointments.s_hwcfg);
            v_file.Close();

            u_Confighandler.configset(s_path + o_homework.s_hash + u_Vars.appointments.s_hwcfg);
            u_Confighandler.write(u_Vars.appointments.s_defcfg);
            u_Confighandler.writestring(u_Vars.appointments.s_cfgreg,u_Vars.appointments.s_cfg_deadline,u_Stringmanager.Stringfromdate(o_homework.o_date));
            u_Confighandler.writestring(u_Vars.appointments.s_cfgreg,u_Vars.appointments.s_cfg_subject,o_homework.s_subject);

            u_Confighandler.configset(s_path + o_homework.s_hash + u_Vars.appointments.s_textfile);
            u_Confighandler.write(o_homework.s_text);

            AddHash(o_homework.s_hash);
            SaveAppointHashes();

            return true;
        }
        public static void DeleteAppoint(string s_hash)
        {
            string s_path = u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_appointments + s_sp;
            if (File.Exists(s_path + s_hash + u_Vars.appointments.s_hwcfg)) {
                File.Delete(s_path + s_hash + u_Vars.appointments.s_hwcfg);
            }
            if (File.Exists(s_path + s_hash + u_Vars.appointments.s_textfile)) {
                File.Delete(s_path + s_hash + u_Vars.appointments.s_textfile);
            }
            for (int i_index = 0; i_index < u_Project.appointments.s_appoints.Length; i_index++)
            {
                if(u_Project.appointments.s_appoints[i_index] == s_hash)
                {
                    RemoveHash(i_index);
                    return;
                }
            }
        }
        public static s_Appointment LoadAppoint(string s_hash)
        {
            string s_path = u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_appointments + s_sp;

            if (!File.Exists(s_path + s_hash + u_Vars.appointments.s_hwcfg)) { return new s_Appointment(); }
            if (!File.Exists(s_path + s_hash + u_Vars.appointments.s_textfile)) { return new s_Appointment(); }

            s_Appointment o_temphw = new s_Appointment();
            u_Confighandler.configset(s_path+s_hash+ u_Vars.appointments.s_hwcfg);
            string s_deadline = u_Confighandler.readstring(u_Vars.appointments.s_cfgreg,u_Vars.appointments.s_cfg_deadline);

            if(s_deadline == null)
            {
                return new s_Appointment();
            }

            o_temphw.s_subject = u_Confighandler.readstring(u_Vars.appointments.s_cfgreg,u_Vars.appointments.s_cfg_subject);
            o_temphw.o_date = u_Stringmanager.Datefromstring(s_deadline);

            u_Confighandler.configset(s_path + s_hash + u_Vars.appointments.s_textfile);
            o_temphw.s_text = u_Confighandler.read();
            o_temphw.s_hash = s_hash;


            return o_temphw;
        }
        public static void SaveAppoint(string s_hash,string s_text)
        {
            string s_path = u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.s_appointments + s_sp;
            if (!File.Exists(s_path + s_hash + u_Vars.appointments.s_textfile)) { return; }

            u_Confighandler.configset(s_path + s_hash + u_Vars.appointments.s_textfile);
            u_Confighandler.write(s_text);

        }
        public static string HashGen(s_Appointment o_homework)
        {
            string s_hash = o_homework.s_subject.Replace("_", "");
            s_hash = s_hash.ToLower() + "_";
            s_hash += o_homework.o_date.Year.ToString();
            if (o_homework.o_date.Month < 10)
            {
                s_hash += "0" + o_homework.o_date.Month.ToString();
            }
            else
            {
                s_hash += o_homework.o_date.Month.ToString();
            }
            if (o_homework.o_date.Day < 10)
            {
                s_hash += "0" + o_homework.o_date.Day.ToString();
            }
            else
            {
                s_hash += o_homework.o_date.Day.ToString();
            }
            if (o_homework.o_date.Hour < 10)
            {
                s_hash += "0" + o_homework.o_date.Hour.ToString();
            }
            else
            {
                s_hash += o_homework.o_date.Hour.ToString();
            }
            if (o_homework.o_date.Minute < 10)
            {
                s_hash += "0" + o_homework.o_date.Minute.ToString();
            }
            else
            {
                s_hash += o_homework.o_date.Minute.ToString();
            }
            return s_hash;
        }

        public static void AddHash(string s_hash)
        {
            string[] s_hashpool = new string[u_Project.appointments.s_appoints.Length + 1];
            for (int i_index = 0; i_index < u_Project.appointments.s_appoints.Length; i_index++)
            {
                s_hashpool[i_index] = u_Project.appointments.s_appoints[i_index];
            }
            s_hashpool[u_Project.appointments.s_appoints.Length] = s_hash;
            u_Project.appointments.s_appoints = s_hashpool;
        }
        public static void RemoveHash(int i_pos)
        {
            string[] s_hashpool = new string[u_Project.appointments.s_appoints.Length - 1];
            for (int i_index = 0, i_subindex = 0; i_index < s_hashpool.Length; i_index++, i_subindex++)
            {
                if (i_subindex == i_pos)
                {
                    i_subindex++;
                }
                s_hashpool[i_index] = u_Project.appointments.s_appoints[i_subindex];
            }
            u_Project.appointments.s_appoints = s_hashpool;

        }
        public static bool SaveAppointHashes()
        {
            u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg);

            return u_Listhandler.writestringlist(u_Project.appointments.s_appoints);

        }
        public static bool LoadAppointHashes()
        {
            u_Listhandler.configset(u_Project.software.s_projectfolder + s_sp + u_Vars.s_resources + s_sp + u_Vars.appointments.s_contcfg);
            u_Project.appointments.s_appoints = u_Listhandler.readstringlist();
            if (u_Project.appointments.s_appoints == null)
            {
                u_Project.appointments.s_appoints = new string[0];
                return false;
            }
            return true;
        }
    }
}
