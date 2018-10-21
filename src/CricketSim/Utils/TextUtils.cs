using System;
using Services;
using SimpleInjector;

namespace Utils
{
    public static class TextUtils
    {
        public static string _T(string key)
        {
            var container = new Container();
            ResourceManager rm = container.GetInstance<ResourceManager>();
            return rm.Get(key);
        }
    }
}