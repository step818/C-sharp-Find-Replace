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
      int uWordEnd = (uWord.Length - 1); //placeholder while entire uWord is checked
      int startIndex = 0;
      string potentialName = "";
      for(int i = 0, j = 0; i < uPhrase.Length; i++)
      {
        if(uPhrase[i] == uWord[j])
        {
          if(j == uWordEnd)
          {
            startIndex = i - j;
            result=result + Name;
            j = 0;
            potentialName = "";
          }
          else
          {
            potentialName = potentialName + uPhrase[i];
            j++;
          }
        }
        else
        {
          result += potentialName + uPhrase[i] ;
          j = 0;
          potentialName = "";
        }
      }
      return result;
    }
  }
}