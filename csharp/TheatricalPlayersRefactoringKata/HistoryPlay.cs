namespace TheatricalPlayersRefactoringKata
{
    public class HistoryPlay : Play
    {
        public HistoryPlay(string name) : base(name, "history")
        {
        }
        public override int GetAmount(int audience)
        {
            int baseAmount = 50000;
            if (audience > 30)
            {
                baseAmount += 1000 * (audience - 30);
            }
            return baseAmount;
        }
    }
}
