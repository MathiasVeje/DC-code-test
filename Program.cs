using System;
using System.Collections.Generic;

namespace DCCodeTest {
    class Program {
        static void Main (string[] args) {
            List<IPlayer> playerNames = new List<IPlayer> ();

            Console.WriteLine ("\nNumber of players (1 to 6)");
            int numOfPlayers = Convert.ToInt32 (Console.ReadLine ());

            for (int i = 0; i < numOfPlayers; i++) {
                Console.WriteLine ($"\nName of {AddOrdinal(i+1)}");
                playerNames.Add (new Player (Console.ReadLine ()));
            }
            playerNames.Add (new Player ("q"));

            for (int i = 1; i < 11; i++) {
                foreach (IPlayer player in playerNames) {
                    Console.WriteLine ("Input score for " + player.getName () + "'s first roll in the " + AddOrdinal (i) + " frame");
                    int firstRoll = Convert.ToInt32 (Console.ReadLine ());
                    int secondRoll = 0;
                    if (firstRoll == 10) {
                        Console.WriteLine ("WOW " + player.getName () + " got a STRIKE");
                    } else {
                        Console.WriteLine ("Input score for " + player.getName () + "'s second roll in the " + AddOrdinal (i) + " frame");
                        secondRoll = Convert.ToInt32 (Console.ReadLine ());
                        if (firstRoll + secondRoll == 10) {
                            Console.WriteLine ("WOW " + player.getName () + " got a SPARE");
                        }
                    }
                    player.setScoreForframe (firstRoll, secondRoll);
                    Console.WriteLine ("Total score: " + player.getScore ());
                }
            }

            string AddOrdinal (int num) {
                switch (num) {
                    case 1:
                        return num + "st";
                    case 2:
                        return num + "nd";
                    case 3:
                        return num + "rd";
                    default:
                        return num + "th";
                }
            }
        }
    }
}