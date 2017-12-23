using SimCorp.IMS.MobilePhoneLibrary.General;
using System.Text;

namespace SimCorp.IMS.Fake
{
    public class OutputMock : IOutput
    {
        public string Output
        {
            get
            {
                return myText.ToString();
            }
        }
        private StringBuilder myText = new StringBuilder();

        public void Write(string text)
        {
            myText.Append(text);
        }

        public void WriteLine(string text)
        {
            Write(text);
            myText.AppendLine();
        }

        
    }
}
