using System.Collections.Generic;

namespace Hangman.Models
{
  public class Player
  {
    private string _name;
    private int _gamesPlayed;
    // private static List<Item> _instances = new List<Item> {};
    private int _rightGuesses;
    private int _wrongGuesses;
    private int _wins;


    public Player (string myName)
    {
      _name = myName;
      _gamesPlayed = 0;
      _rightGuesses = 0;
      _wrongGuesses = 0;
      _wins = 0;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string aName)
    {
      _name = aName;
    }

    public string GetGamesPlayed()
    {
      return _gamesPlayed;
    }
    public void SetGamesPlayed(string myGames)
    {
      _gamesPlayed = myGames;
    }

    public string GetRightGuesses()
    {
      return _rightGuesses;
    }
    public void SetRightGuesses(int myRights)
    {
      _rightGuesses = myRights;
    }

    public string GetWrongGuesses()
    {
      return _wrongGuesses;
    }
    public void SetWrongGuesses(int myWrongs)
    {
      _wrongGuesses = myWrongs;
    }

    public string GetWins()
    {
      return _wins;
    }
    public void SetName(string myWins)
    {
      _wins = myWins;
    }


  }
}
