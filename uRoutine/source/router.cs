using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalConfig;

namespace User.Source
{ 
    public static class Router
    {
        public static Lists<string> s_ProjectFiles = new Lists<string>();
        public static int i_CurrentProject=-1;

        private static string s_File = Application.StartupPath + "\\router.ufg";

        public static void LoadData()
        {

            if (File.Exists(s_File))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_File))
                {
                    o_Reader.LoadConfig();
                    s_ProjectFiles.o_Content = o_Reader.GetAsStringArray("ROUTER", "LINK", typeof(string));
                    i_CurrentProject = o_Reader.GetValue<int>("ROUTER", "CURRENT");
                }
            }
            else
            {
                CreateFile();
            }
        }
        public static void SaveData(bool b_Repeat=true)
        {
            if (File.Exists(s_File))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_File))
                {

                    o_Reader.SetArray<string>("ROUTER", "LINK", s_ProjectFiles.o_Content);
                    o_Reader.SetValue<int>("ROUTER", "CURRENT", i_CurrentProject);

                    o_Reader.SaveConfig();
                }
            }
            else
            {
                CreateFile();
                if(b_Repeat)SaveData(false);
            }
        }
        public static void CreateFile()
        {
            using (UniversalConfigCreator o_Creator = new UniversalConfigCreator(s_File))
            {
                o_Creator.AppendUnit("ROUTER");
                o_Creator.AppendRegister("ROUTER","LINK",typeof(string));
                o_Creator.AppendRegister("ROUTER","CURRENT",typeof(int));
                o_Creator.Build();
            }
        }
        public static bool GetCurrentDir(out  string s_Dir)
        {
            s_Dir = null;
            if (i_CurrentProject == -1) return false;
            if (s_ProjectFiles.o_Content[i_CurrentProject] == null) return false;
            s_Dir=s_ProjectFiles.o_Content[i_CurrentProject]+"\\";
            return true;
        }
    }
}
