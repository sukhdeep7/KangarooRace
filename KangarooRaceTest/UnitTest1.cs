﻿using KangarooRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KangarooRaceTest
{
    [TestClass]
    public class UnitTest1
    {
        PunterFactory pFactory = new PunterFactory();
        Punter Jaspreet;
        Kangaroo[] Kangaroos = new Kangaroo[2];

        [TestMethod]
        public void TestWinnerOutcome()
        {
            Kangaroo.StartingPosition1 = 0;
            Kangaroo.RacetrackLength1 = 50;
            int BettingAmount = 45;
            int KangarooNumber = 1;
            int expectedWin = 90;
            int expectedLose = 0;
            Kangaroos[0] = new Kangaroo() { KangarooPictureBox = null };
            Kangaroos[1] = new Kangaroo() { KangarooPictureBox = null };
            Jaspreet = pFactory.getPunter("Jaspreet", null, null);
            Jaspreet.Cash = BettingAmount;
            Jaspreet.PlaceBet((int)BettingAmount, KangarooNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Kangaroos.Length; i++)
                {
                    if (Kangaroo.Run(Kangaroos[i]))
                    {
                        win = i + 1;
                        Jaspreet.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Jaspreet.bet.KangarooNum == win)
            {
                Assert.AreEqual(expectedWin, Jaspreet.Cash, "Account not credited correctly");
            }
            if (Jaspreet.bet.KangarooNum != win)
            {
                Assert.AreEqual(expectedLose, Jaspreet.Cash, "Account not debited correctly");

            }
        }
    }

}
