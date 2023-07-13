using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMITool
{
    internal static class Strings
    {
        public const string ERROR_EMPTY_ARGS = "Args must contains file path.";
        public const string ERROR_INVALID_FILE = "Invalid file path.\nMay be file does not exists, file is empty or too large.";
        public const string ERROR_UPLOAD_FAILED = "Failed to upload file. Check your internet connection.";
    }
}
