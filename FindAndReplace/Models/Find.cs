using System;

namespace FindAndReplace.Models
{
  public class Find
  {
    public string Paragraph { get; set; }
    public string Word { get; set; }
    public Find(string paragraph, string word)
    {
      Paragraph = paragraph;
      Word = word;
    }
    public bool ThisWord()
    {
      return Paragraph.Contains(Word);
    }
    public int NumberOfTimes()
    {
      int count = 0;
      for(int i = 0; i < Paragraph.Length; i++)
      {
        if (i == Paragraph.IndexOf(Word))
        {
          count+=1;
          Console.WriteLine(i);
        }
      }
      return count;
    }
  }
}