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
      for(int i = 0, j = 0; i < Paragraph.Length; i++)
      {
        if(Paragraph[i] == Word[j])
        {
          if(j == Word.Length-1) // if word is found
          {
            count++;
            j = 0; // reset
          }
          else
          {
            j++;
          }
        }
        else
        {
          j = 0; // reset
        }
      }
      return count;
    }
  }
}