using System;

namespace L2CoreDotNET.Commons.Logging
{
    public static class MasterFormatter
    {
        public static readonly String SHIFT = "\tat";

        public static readonly String CELF = "\r\n";

        public static readonly String SPACE = "\t";

        public static String GetFormatedDate(this DateTime dateTime) => dateTime.ToString("yyyy-MM-dd HH':'mm':'ss");




    }
}
