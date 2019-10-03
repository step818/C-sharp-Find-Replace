using System;

namespace FindAndReplace.Models
{
  public class Replace
  {
    public string Name { get;set; }
    public Find InheritedInfo { get;set; }
    public Replace(Find inherited, string name)
    {
      InheritedInfo = inherited;
      Name = name;
    }
    public string NewPhrase()
    {
      string uPhrase = InheritedInfo.Paragraph;
      string uWord = InheritedInfo.Word;
      string result = "";
      for(int i = 0, j = 0; i < uPhrase.Length; i++)
      {
        if(uPhrase[i] == uWord[j])
        {
          if(j == uWord.Length - i)
          {
            result += Name;
            j = 0; // reset
          }
          else
          {
            j++;
          }
        }
        else
        {
          result += uPhrase[i];
        }
      }
      return result;
    }
  }
}