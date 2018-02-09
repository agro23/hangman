using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    private string _score;
    private int _gamesPlayed;
    // private static List<Item> _instances = new List<Item> {};
    private int _boardState;
    private string[] _words = new string[] {};
    private int _hanger;
    private string _guessState;

    public Player (string myScore)
    {
      _score = myScore;
      _gamesPlayed = 0;
      _boardState = 0;
      _words = {"special", "ahead", "help",
      "pull",
      "fact",
      "test",
      "hollow",
      "record",
      "adaptable",
      "overflow",
      "flowery",
      "hands",
      "tense",
      "grape",
      "sincere",
      "hapless",
      "fire",
      "debt",
      "vengeful",
      "sticky",
      "tranquil",
      "steam",
      "pumped",
      "uncovered",
      "like" }
      _hanger = 0;
      _wins = 0;
      _guessState = "";
    }

    public string GetScore(){
      return _score;
    }

    public void SetScore(int gameScore){
      _score = gameScore();
    }

    public string GetBoardState(){
      return _boardState;
    }

    public void SetBoardState(int gameBoardState){
      _boardState = gameBoardState();
    }

    public int GetHanger(){
      return _hanger();
    }

    public void SetHanger(int gameHanger){
      _hanger = gameHanger();
    }

    public void Turn (){

    }

  }
}
