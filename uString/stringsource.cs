using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Source
{
    public static class u_Stringsource
    {
        public const string s_appname = "Routine";

        public const string s_fontpath = @"LogicoSansRegular.ttf";

        public const string s_versionfile= @"version.ucp";
        public const string s_version = @"setup.exe";
        public const string s_version_update = "update";
        public const string s_version_settings= "setting";


        public const string s_fontname = @"Logico Sans";
        public const string s_logfile = @"debug.log";
        public const string s_supfolder= @"/programfiles/";
        public const string s_logformat= "[ (DATE) ] <(TITLE)>: (TEXT)";
        public const string s_website = @"https://www.ucpsystems.com/";
        public const string s_website_help = @"https://www.ucpsystems.com/index.php?site=about";
        public const string s_defaultcfg= "[UCFG/C]{[UNIT=(acc)]{[REG=(name);TYPE=(str);VALUE=(empty)],[REG=(code);TYPE=(str);VALUE=(empty)]}}";
        public const string s_defaultcfgfile= "config.cfg";

        public const string s_createfile = "Create a File";
        public const string s_openfile = "Select a File";
        public const string s_filefilter_ucp = "UCP File (*.ucp)|*.ucp";
        public const string s_filefilter_zip = "ZIP File (*.zip)|*.zip";
        public const string s_filemissing =" [MISSING]";

        public const string s_confiles = "Contains ? files.";
        public const string s_daysleft = " days left.";

        public const string s_fileinfo_date = "Date: ";
        public const string s_fileinfo_subject = "Subject: ";
        public const string s_fileinfo_longterm = "Longterm Project";
        public const string s_fileinfo_shortterm = "Single Lesson";

        public const string s_homework_showall = "Show All";
        public const string s_homework_back = "Back";
        public const string s_homework= "Homework Notifier";
        public const string s_homework_ask= "Go there?";
        public const string s_homework_have = "You have homework to do in ? subjects!";
        public const string s_homework_tomorrow = "Dont forget your homework for Tomorrow!";
        public const string s_homework_no = "You have nothing to do for now!";

        public enum e_messagelist {Universal = 0,IOError = 1,Fonterror = 2,Loginerror = 3, Exit = 4,Loadedfont = 5,Logged=6, Loggedout = 7,UCPIO = 8};
        public static readonly string[] s_message_title= {
            "URE",
            ".NET-IO",
            "Font",
            "Login",
            "Exit",
            "Font",
            "Login",
            "Login",
            "UCP-IO"
        };
        public static readonly string[] s_message_text= {
            "An unknown error occourt! Please restart the application!",
            "Error while writing or reading a filestream!",
            "A font is missing! Please install this font in order to continue!",
            "The loginmanager failed to maintane the connection!",
            "Software reached endpoint!",
            "Font loaded!",
            "Connection to server established!",
            "Deleting profiles! Logging out!",
            "# could not be read."
          
        };

        public static readonly string[] s_load_text = {
            "Hello new user! To start working you need to create a project",
            "The project is missing essential files! Unable so start!",
            "The project is missing essential files! Do you want to start the repair tool?",
            "Some folders where repaired but the project might be crashed completely!",
            "Something went wrong with the software route config! Don't panic, we are going to fix the problem!",
            "No project is loaded or could be loctated. Waiting for Input.",
            "Oh no! The Project Info is not readable!",
            "Almost done! Type in your current Grade ...",
            "Cannot save! Only Numbers and Letters are allowed as a Grade!",
            "The timtable file needs to be located in the project folder!",
            "Please enter you subjects and you can start working!",
            "One or more files are Missing or are unreadable!",
            "The lesson was not found!",
            "This file already exists! Do you want to Replace it?",
            "Please enter a valid filename!",
            "There are # files missing! Do you want to remove them from the list?",
            "Do you want to open all files?",
            "Installer is missing!",
            "Could not connect to the server! Startig offline",
            "Are you sure about deleting this Lesson?"
        };
        public static readonly string[] s_load_title = {
            "Wellcome!",
            "Files Missing!",
            "Files Missing!",
            "Please Note!",
            "Error!",
            "Error",
            "Fatal error!",
            "Please Note",
            "Please Note",
            "Please Note",
            "Please Note",
            "Fatal error!",
            "Fatal error!",
            "File error!",
            "File error!",
            "Files Missing",
            "Project",
            "Settings",
            "Offline",
            "Delete Lesson"
        };
    }
}
