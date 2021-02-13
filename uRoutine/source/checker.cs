using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Source
{
    public static class Checker
    {
        public static bool CheckValid(string s_Text)
        {
            char[] c_Forbiden = { ']', '[', '{', '}', ':', '=', '#' };
            for (int i_Index = 0; i_Index < c_Forbiden.Length; i_Index++)
            {
                if (s_Text.Contains(c_Forbiden[i_Index])) return false;
            }
            return true;
        }
        public static string ExtractFileName(string s_Path)
        {
            string[] s_Split = s_Path.Split('\\');
            return s_Split[s_Split.Length - 1];
        }
    }
}
