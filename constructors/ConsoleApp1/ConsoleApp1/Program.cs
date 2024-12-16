using ConsoleApp1;


namespace Functions
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Run();
            Console.WriteLine("Hello, World!");
        }
        void Run()
        {
            QuizVraag quizVraag = new QuizVraag("hier komt de vraag?", "hier komt het antwoord");
        }

    }
}




