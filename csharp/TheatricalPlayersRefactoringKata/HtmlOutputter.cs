using System.Text;

namespace TheatricalPlayersRefactoringKata
{
    public class HtmlOutputter : IOutputter
    {
        private StringBuilder _sb = new StringBuilder();

        public void Append(string text)
        {
            string htmlText = text.Replace("\n", "<br />\n");
            _sb.Append(htmlText);
        }

        public string GetOutput()
        {
            return _sb.ToString();
        }
    }
}
