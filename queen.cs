using System;
using System.Collections.Generic;

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
  public static void Main()
  {
    Console.WriteLine("Please enter coordinates for the Queen");
    int Queenx = int.Parse(Console.ReadLine());
    int Queeny = int.Parse(Console.ReadLine());
    Queen queenPlayer = new Queen(Queenx,Queeny);

    Console.WriteLine("Please enter the coordinates in for the Pawn");
    int Pawnx = int.Parse(Console.ReadLine());
    int Pawny = int.Parse(Console.ReadLine());
    Pawn pawnPlayer = new Pawn(Pawnx, Pawny);


    for(int i = queenPlayer.X; i < 8; i++) {
      for(int j = queenPlayer.Y; j < 8; j++) {
        if(pawnPlayer.X == i && pawnPlayer.Y == j) {
          Console.WriteLine("first diagonal rule done");
        }
      }
    }
    for(int i = queenPlayer.X; i > 0; i--) {
      Console.WriteLine(i);
      for(int j = queenPlayer.Y; j < 8; j++) {
        if(pawnPlayer.X == i && pawnPlayer.Y == j) {
          Console.WriteLine("Second diagonal rule done");
        }
      }
    }
  }
}

// for(int p = queenPlayer.X; p < 0; p--) {
    //   Console.WriteLine(p);
    //   for(int o = queenPlayer.Y; o < 8; o++) {
    //     if(pawnPlayer.X == p && pawnPlayer.Y == o) {
    //       Console.WriteLine("Second diagonal rule done");
    //     }
    //   }
    // }
//     // horizontal and vertical checker
//     if(pawnPlayer.X == queenPlayer.X || pawnPlayer.Y == queenPlayer.Y){
//       Console.WriteLine("Attack Made");
//     }
//   }
// }
