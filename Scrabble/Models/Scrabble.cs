using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{

  public class Score {

    public string Entry { get; set; }

    private static Dictionary<string, int> letterDictionary = new Dictionary<string, int>() 
    {
      {"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10}
    };

    //Constructor
    public Score(string entry)
    {
      Entry = entry;
    }

    public int CalculateScore () 
    {
      
      //char[] characterArray = Entry.ToCharArray();
      //Console.WriteLine(characterArray.GetType());
      // string myCharacterArray = characterArray.Split(String[", "]);
      //Console.WriteLine(characterArray);
      int wordscore = 0;
      foreach(char myChar in Entry)
      {
        // Console.WriteLine(myChar.ToString( ));
        string myString = myChar.ToString();
        int letterScore = letterDictionary[myString];
        wordscore += letterScore;
      }
      return wordscore;
    }

  }
}

// int wordscore = 0 ;
// foreach(char myChar in letterDictionary)
// {
// int letterscore = letterDictionary[myChar];
// wordscore += letterScore;
// }













