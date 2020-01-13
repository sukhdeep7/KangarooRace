using System.Windows.Forms;

namespace KangarooRace
{
    public class Jaspreet : Punter
    {
        public Jaspreet(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "Jaspreet";
        }
    }
    public class Harman : Punter
    {
        public Harman(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Harman";
        }
    }
    public class Raj : Punter
    {
        public Raj(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Raj";
        }
    }
}
