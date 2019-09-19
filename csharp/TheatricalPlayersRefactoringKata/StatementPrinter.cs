using System;
using System.Collections.Generic;
using System.Globalization;

namespace TheatricalPlayersRefactoringKata
{
    public class StatementPrinter
    {
        private readonly IOutputter _outputter;

        public StatementPrinter() : this(new TextOutputter())
        {
        }

        public StatementPrinter(IOutputter outputter)
        {
            _outputter = outputter;
        }

        public string Print(Invoice invoice, Dictionary<string, Play> plays)
        {
            var totalAmount = 0;
            var volumeCredits = 0;
            _outputter.Append(string.Format("Statement for {0}\n", invoice.Customer));
            CultureInfo cultureInfo = new CultureInfo("en-US");

            foreach(var perf in invoice.Performances) 
            {
                var play = plays[perf.PlayID];
                var thisAmount = play.GetAmount(perf.Audience);

                volumeCredits += play.GetVolumeCredits(perf.Audience);

                // print line for this order
                _outputter.Append(String.Format(cultureInfo, "  {0}: {1:C} ({2} seats)\n", play.Name, Convert.ToDecimal(thisAmount / 100), perf.Audience));
                totalAmount += thisAmount;
            }
            _outputter.Append(String.Format(cultureInfo, "Amount owed is {0:C}\n", Convert.ToDecimal(totalAmount / 100)));
            _outputter.Append(String.Format("You earned {0} credits\n", volumeCredits));
            return _outputter.GetOutput();
        }
    }
}
