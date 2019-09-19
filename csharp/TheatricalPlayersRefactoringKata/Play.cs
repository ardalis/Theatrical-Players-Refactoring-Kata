using System;

namespace TheatricalPlayersRefactoringKata
{
    public abstract class Play
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        protected Play(string name, string type) {
            this.Name = name;
            this.Type = type;
        }

        public static Play GetPlayByType(string name, string playType)
        {
            switch (playType)
            {
                case "tragedy":
                    return new TragedyPlay(name);
                case "history":
                    return new HistoryPlay(name);
                case "pastoral":
                    return new PastoralPlay(name);
                case "comedy":
                    return new ComedyPlay(name);
                default:
                    throw new Exception("unknown type: " + playType);
            }
        }

        public abstract int GetAmount(int audience);

        public virtual int GetVolumeCredits(int audience)
        {
            return Math.Max(audience - 30, 0);
        }
    }
}
