namespace TheatricalPlayersRefactoringKata
{
    public class PastoralPlay : Play
    {
        public PastoralPlay(string name) : base(name, "pastoral")
        {
        }
        public override int GetAmount(int audience)
        {
            int baseAmount = 60000;
            if (audience > 30)
            {
                baseAmount += 1000 * (audience - 30);
            }
            return baseAmount;
        }
    }
}
