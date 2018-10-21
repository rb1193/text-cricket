using System;
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
        
        public string _T(string key, object[] replace = null)
        {
            return String.Format(_rh.Get(key), replace);
        }
    }
}