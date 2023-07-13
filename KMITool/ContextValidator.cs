using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMITool
{
    internal static class ContextValidator
    {
        private const int MAXIMAL_FILE_SIZE = 1024 * 128;

        public static bool validateArgs(String[] args)
        {
            return args.Length == 1;
        }

        public static bool validateFile(String path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists) return false;
            if (fileInfo.Length == 0) return false;
            if (fileInfo.Length > MAXIMAL_FILE_SIZE) return false;
            return true;
        }
    }
}
