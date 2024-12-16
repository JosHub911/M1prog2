using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
     internal class QuizVraag
    {
        internal string vraag;
        internal string antwoord;


        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }


    }
}
