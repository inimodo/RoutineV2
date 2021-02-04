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

    public struct RouterRoutes
    { 
        public string[] s_ProjectFiles;
        public int i_CurrentProject;
    }
    public static class Router
    {
        private static string s_File = Application.StartupPath + "\\router.ufg";

        public static void LoadData(out RouterRoutes o_Routes)
        {
            o_Routes = new RouterRoutes();
            o_Routes.i_CurrentProject = 0;
            o_Routes.s_ProjectFiles = new string[0];

            if (File.Exists(s_File))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_File))
                {
                    o_Reader.LoadConfig();
                    o_Routes.s_ProjectFiles = o_Reader.GetArray<string>("ROUTER", "LINK");
                    o_Routes.i_CurrentProject = o_Reader.GetValue<int>("ROUTER", "CURRENT");
                }
            }
            else
            {
                CreateFile();
                SaveData(o_Routes);
            }
        }
        public static void SaveData(RouterRoutes o_Routes,bool b_Repeat=true)
        {
            if (File.Exists(s_File))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_File))
                {
                    o_Reader.SetArray<string>("ROUTER", "LINK", o_Routes.s_ProjectFiles);
                    o_Reader.SetValue<int>("ROUTER", "CURRENT", o_Routes.i_CurrentProject);
                    o_Reader.SaveConfig();
                }
            }
            else
            {
                CreateFile();
                if(b_Repeat)SaveData(o_Routes,false);
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
    }
}
