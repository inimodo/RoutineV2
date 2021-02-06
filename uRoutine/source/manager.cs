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
        public static string[] s_ProjectFiles=null;
        public static int i_CurrentProject=-1;

        private static string s_File = Application.StartupPath + "\\router.ufg";

        public static void LoadData()
        {

            if (File.Exists(s_File))
            {
                using (UniversalConfigReader o_Reader = new UniversalConfigReader(s_File))
                {
                    o_Reader.LoadConfig();
                    s_ProjectFiles = o_Reader.GetAsStringArray("ROUTER", "LINK", typeof(string));
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

                    o_Reader.SetArray<string>("ROUTER", "LINK", s_ProjectFiles);
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
        public static void AddRoute(string s_Path)
        {
            string[] s_Temp;
            if (s_ProjectFiles == null)
            {
                s_Temp = new string[1];
                s_Temp[0] = s_Path;
            }
            else
            {
                s_Temp = new string[s_ProjectFiles.Length + 1];
                for (int i_Index = 0; i_Index < s_ProjectFiles.Length; i_Index++)
                {
                    s_Temp[i_Index] = s_ProjectFiles[i_Index];
                }
                s_Temp[s_ProjectFiles.Length] = s_Path;
            }
            s_ProjectFiles = new string[s_Temp.Length];
            s_ProjectFiles = s_Temp;
        }
        public static void DelRoute(int i_RouteIndex)
        {
            if (i_RouteIndex >= s_ProjectFiles.Length)return;
           
            string[] s_Temp = new string[s_ProjectFiles.Length - 1];
            for (int i_Index = 0,i_OffsetIndex =0; i_Index < s_ProjectFiles.Length-1; i_OffsetIndex++ ,i_Index++)
            {
                if (i_Index == i_RouteIndex) i_OffsetIndex++;
                s_Temp[i_Index] = s_ProjectFiles[i_OffsetIndex];
            }
            s_ProjectFiles = new string[s_ProjectFiles.Length-1];
            s_ProjectFiles = s_Temp;
            if (s_ProjectFiles.Length == 0) s_ProjectFiles = null;
        }
    }
}
