using System;
using System.Collections.Generic;
// [System.ComponentModel.TypeConverter(typeof(System.Windows.PointConverter))]
// [System.Serializable]
// public struct Point : IFormattable



class Queen
{
  public int X {get; set;}
  public int Y {get; set;}

  public Queen(int x, int y){
    X = x;
    Y = y;
  }
}
class Pawn
{
  public int X {get; set;}
  public int Y {get; set;}

  public Pawn(int x, int y) {
    X = x;
    Y = y;
  }
}
  public class Program
  {
  public static void Main(){
    Console.WriteLine("Please enter coordinates for the Queen");
    int Queenx = int.Parse(Console.ReadLine());
    int Queeny = int.Parse(Console.ReadLine());
    Queen queenPlayer = new Queen(Queenx,Queeny);

    Console.WriteLine("Please enter the coordinates in for the Pawn");
    int Pawnx = int.Parse(Console.ReadLine());
    int Pawny = int.Parse(Console.ReadLine());
    Pawn pawnPlayer = new Pawn(Pawnx, Pawny);


    if(pawnPlayer.X == queenPlayer.X || pawnPlayer.Y == queenPlayer.Y){
      Console.WriteLine("Attack Made");
    }
    else {
      Console.WriteLine("Attack Not Made, You're Trash!");
    }
  }
}
