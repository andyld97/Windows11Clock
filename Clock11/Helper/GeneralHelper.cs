﻿using System;

namespace Clock11.Helper
{
    public static class GeneralHelper
    {
        /// <summary>
        /// Opens the default system browser with the requested uri
        /// https://stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp/67838115#67838115
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static bool OpenUri(Uri uri)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", $"\"{uri}\"");
                return true;
            }
            catch (Exception)
            {
                // ignore 
                return false;
            }
        }
    }
}
