using System.Collections.Generic;
using System;
using System.Linq;

namespace Instances.Objects
{
  public class InstanceGenerator
  {

    private string _wordOriginal;
    private List<string> _letters = new List<string>{};

    public InstanceGenerator(string word)
    {
      _wordOriginal = word;
      Char[] charArray = word.ToUpper().ToCharArray();
      foreach (char letter in charArray)
      {
        _letters.Add(letter.ToString());
      }
      if _letters.Match();
    }

    public List<string> LetterList()
    {
      return _letters;
    }
  }
}
