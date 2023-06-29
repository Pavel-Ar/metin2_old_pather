using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
    class Globals
    {
        public static string PatchServerURL = "http://m2.moz.su/patch/";
        public static string PatchNewsURL   = PatchServerURL+"news";
        public static string RegisterURL    = "http://m2.moz.su/users/register";
        public static string AccountURL     = "http://m2.moz.su/users/login";
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "metin2.bin";
        public static string ConfigName     = "config.exe";

        public static pForm pForm;

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long fullSize;
        public static long completeSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}
