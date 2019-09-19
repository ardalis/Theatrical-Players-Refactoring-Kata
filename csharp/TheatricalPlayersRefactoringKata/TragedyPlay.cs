namespace TheatricalPlayersRefactoringKata
{
    public class TragedyPlay : Play
    {
        public TragedyPlay(string name) : base(name, "tragedy")
        {
        }

        public override int GetAmount(int audience)
        {
            int baseAmount = 40000;
            if (audience > 30)
            {
                baseAmount += 1000 * (audience - 30);
            }
            return baseAmount;
        }
    }
}
