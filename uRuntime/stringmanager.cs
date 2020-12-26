using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public static class u_Stringmanager
    {
        private const char c_split = 'D';
        public static DateTime Datefromstring(string s_date)
        {
            string[] s_dates = s_date.Split(c_split);
            int i_day = int.Parse(s_dates[0]);
            int i_month = int.Parse(s_dates[1]);
            int i_year = int.Parse(s_dates[2]);
            int i_min = int.Parse(s_dates[3]);
            int i_hour = int.Parse(s_dates[4]);
            return new DateTime(i_year, i_month, i_day, i_hour, i_min, 0);
        }
        public static string Stringfromdate(DateTime o_date)
        {
            return o_date.Day.ToString() + c_split +
                o_date.Month.ToString() + c_split +
                o_date.Year.ToString() + c_split +
                o_date.Minute.ToString() + c_split +
                o_date.Hour.ToString();
        }
        public static string ToReadDate(DateTime o_date)
        {
            string s_date = "";
            if (o_date.Day < 10)
            {
                s_date += "0" + o_date.Day;
            }
            else
            {
                s_date += o_date.Day;
            }
            s_date += ".";
            if (o_date.Month < 10)
            {
                s_date += "0" + o_date.Month;
            }
            else
            {
                s_date += o_date.Month;
            }
            s_date += "." + o_date.Year + " ";
            return s_date;
        }
        public static string Gradecorrect(string s_string)
        {
            char[] c_input = s_string.ToCharArray();
            string s_output ="";

            for (int i_index = 0; i_index < c_input.Length; i_index++)
            {
                if (Valitchar_grade(c_input[i_index]))
                {
                    s_output += c_input[i_index];
                }
            }
            return s_output;
        }
        private static bool Valitchar_grade(char c_input)
        {

            if (c_input >= 'A' && c_input <= 'Z')
            {
                return true;
            }
            if (c_input >= 'a' && c_input <= 'z')
            {
                return true;
            }
            if (c_input >= '0' && c_input <= '9')
            {
                return true;
            }
            return false;
        }
        public static string Subjectcorrect(string s_string)
        {
            if (s_string == "") { return null; }
            char[] c_input = s_string.ToCharArray();
            string s_output = "";

            for (int i_index = 0; i_index < c_input.Length; i_index++)
            {
                if (Valitchar_subject(c_input[i_index]))
                {
                    s_output += c_input[i_index];
     
                }
            }

            return s_output;
        }
        private static bool Valitchar_subject(char c_input)
        {
            if (c_input >= 'A' && c_input <= 'Z')
            {
                return true;
            }
            if (c_input >= 'a' && c_input <= 'z')
            {
                return true;
            }
            if (c_input >= '0' && c_input <= '9')
            {
                return true;
            }
            return false;
        }
        public static string Topiccorrect(string s_string)
        {
            if (s_string == "") { return null; }
            char[] c_input = s_string.ToCharArray();
            string s_output = "";
            int i_addc = 0;
            for (int i_index = 0; i_index < c_input.Length; i_index++)
            {
                if (Valitchar_topic(c_input[i_index]))
                {
                    if(c_input[i_index] == ' ')
                    {
                        s_output += '_';
                    }
                    else
                    {
                    s_output += c_input[i_index];

                    }


                    i_addc++;
                }
            }
            if (i_addc == 0) { return null; }
            return s_output;
        }
        private static bool Valitchar_topic(char c_input)
        {
            if (c_input == '_')
            {
                return true;
            }
            if (c_input == ' ')
            {
                return true;
            }
            if (c_input >= 'A' && c_input <= 'Z')
            {
                return true;
            }
            if (c_input >= 'a' && c_input <= 'z')
            {
                return true;
            }
            if (c_input >= '0' && c_input <= '9')
            {
                return true;
            }
            return false;
        }

        public static string Filendcorrect(string s_string)
        {
            if (s_string == "") { return null; }
            char[] c_input = s_string.ToCharArray();
            string s_output = "";
            int i_addc = 0;
            for (int i_index = 0; i_index < c_input.Length; i_index++)
            {
                if (Valitchar_fileend(c_input[i_index]))
                {
                    s_output += c_input[i_index];
                    i_addc++;
                }
            }
            if (i_addc < 1) { return null; }
            return s_output;
        }
        private static bool Valitchar_fileend(char c_input)
        {
            if (c_input >= 'a' && c_input <= 'z')
            {
                return true;
            }
            return false;
        }

        public static string Filecorrect(string s_string)
        {
            if (s_string == "") { return null; }
            char[] c_input = s_string.ToCharArray();
            string s_output = "";
            int i_addc = 0;
            for (int i_index = 0; i_index < c_input.Length; i_index++)
            {
                if (Valitchar_file(c_input[i_index]))
                {
                    if (c_input[i_index] == ' ')
                    {
                        s_output += '_';
                    }
                    else
                    {
                        s_output += c_input[i_index];
                    }
                    i_addc++;
                }
            }
            if (i_addc < 1) { return null; }
            return s_output;
        }
        private static bool Valitchar_file(char c_input)
        {
            if (c_input == '[')
            {
                return false;
            }
            if (c_input == ']')
            {
                return false;
            }
            if (c_input == '{')
            {
                return false;
            }
            if (c_input == '}')
            {
                return false;
            }
            if (c_input == ',')
            {
                return false;
            }
            return true;
        }
    }
}
