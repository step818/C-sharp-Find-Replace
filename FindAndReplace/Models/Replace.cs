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
      string result = "this works";
      return result;
    }
  }
}