using System;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests
{
    public class StatementPrinterTests
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void test_statement_example()
        {
            var plays = new Dictionary<string, Play>();
            plays.Add("hamlet", Play.GetPlayByType("Hamlet", "tragedy"));
            plays.Add("as-like", Play.GetPlayByType("As You Like It", "comedy"));
            plays.Add("othello", Play.GetPlayByType("Othello", "tragedy"));

            Invoice invoice = new Invoice("BigCo", new List<Performance>{new Performance("hamlet", 55),
                new Performance("as-like", 35),
                new Performance("othello", 40)});
            
            StatementPrinter statementPrinter = new StatementPrinter();
            var result = statementPrinter.Print(invoice, plays);

            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void test_statement_with_new_play_types()
        {
            var plays = new Dictionary<string, Play>();
            plays.Add("henry-v", Play.GetPlayByType("Henry V", "history"));
            plays.Add("as-like", Play.GetPlayByType("As You Like It", "pastoral"));

            Invoice invoice = new Invoice("BigCoII", new List<Performance>{new Performance("henry-v", 53),
                new Performance("as-like", 55)});
            
            StatementPrinter statementPrinter = new StatementPrinter();

            var result = statementPrinter.Print(invoice, plays);

            Approvals.Verify(result);
        }
    }
}
