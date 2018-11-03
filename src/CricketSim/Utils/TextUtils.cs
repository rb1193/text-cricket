using System;
using System.Collections.Generic;
using Services;

namespace Utils
{
    public class TextUtils : ITextUtils
    {
        private IResourceHandler _rh;

        public TextUtils(IResourceHandler rh)
        {
            _rh = rh;
        }

        public string _T(string key)
        {
            return _rh.Get(key);
        }
        
        public string _TT(string key, List<string> replacements)
        {
            string text = _rh.Get(key);
            foreach (var item in replacements)
            {
                text = String.Format(text, item);
            }
            return text;
        }
    }
}