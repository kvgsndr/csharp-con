using System;
using System.Collections.Generic;
using System.Text;

namespace string_osztály
{
    class String_osztaly
    {
        string st;
        public String_osztaly(string s)
        {
            st = s;
        }

        public string karakterCsere(char ch, char c)
        {
            string s;
            s = st.ToString();
            return s.Replace(ch, c);
        }
    }
}
