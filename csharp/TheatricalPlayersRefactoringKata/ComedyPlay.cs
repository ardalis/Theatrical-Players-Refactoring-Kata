using System;

namespace TheatricalPlayersRefactoringKata
{
    public class ComedyPlay : Play
    {
        public ComedyPlay(string name) : base(name, "comedy")
        {
        }
        public override int GetAmount(int audience)
        {
            int baseAmount = 30_000;
            if (audience > 20)
            {
                baseAmount += 10000 + 500 * (audience - 20);
            }
            baseAmount += 300 * audience;
            return baseAmount;
        }

        public override int GetVolumeCredits(int audience)
        {
            int credits = base.GetVolumeCredits(audience);

            credits += (int)Math.Floor((decimal)audience / 5);

            return credits;
        }
    }
}
