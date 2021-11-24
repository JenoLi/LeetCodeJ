using System;

namespace Second2021
{
    public static class Tools
    {
        public static string Log(this Array arr)
        {
            string str = "";
            foreach (object o in arr)
            {
                str += o.ToString()+" ";
            }

            return str;
        }
    }
}