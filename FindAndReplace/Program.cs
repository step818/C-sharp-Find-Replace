using System;
using System.Collections.Generic;
using FindAndReplace.Models;

namespace FindAndReplace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("iFind & Relplace!");
      Console.WriteLine("Write a nice poem for me please: ");
      string sentence = Console.ReadLine();
      // Console.WriteLine("I will replace any word or whatever that's found in the paragraph you just wrote with another word.");
      Console.WriteLine("What is the word or sequence of characters you would like me to replace: ");
      string word = Console.ReadLine();
      Find newFind = new Find(sentence, word);
      bool resContains = newFind.ThisWord();
      int resHowMany = newFind.NumberOfTimes();
      Console.WriteLine("Your favorite quote has \"" + word + "\" in it: " + resContains);
      Console.WriteLine("\n" + word + " is in the phrase: " + resHowMany + " times. ");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Replace newText = new Replace(newFind, name);
      string result = newText.NewPhrase();
      Console.WriteLine(result);
    }
  }
}
