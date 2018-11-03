using System.Collections.Generic;

public interface ITextUtils
{
    string _T(string key);
    
    string _TT(string key, List<string> replacements);
}