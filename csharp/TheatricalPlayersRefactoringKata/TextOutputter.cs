using System.Text;

namespace TheatricalPlayersRefactoringKata
{
    public class TextOutputter : IOutputter
    {
        private StringBuilder _sb = new StringBuilder();

        public void Append(string text)
        {
            _sb.Append(text);
        }

        public string GetOutput()
        {
            return _sb.ToString();
        }
    }
}
