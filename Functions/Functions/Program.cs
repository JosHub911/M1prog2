namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //Program is de function en Run is het return type 
            program.Run(); //een class die je moet oproepen
        }

        internal void Run() //Run is function, type is void
        {
            Console.WriteLine("Dit is mijn program nu"); //De function is Writeline en type is void
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
        }

        internal void Vraag1()

        {
            Console.WriteLine("Wat is Ninja zijn haircut?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag2() 
        {
            Console.WriteLine("Wat is still water?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag3() 
        {
            Console.WriteLine("Wie is de slimste van de klas?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag4() 
        {
            Console.WriteLine("Wie is de beste rapper?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag5() 
        {
            Console.WriteLine("Wat is 22 : 10");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal string Vraag6()
        {
            Console.WriteLine("Wat is 22 : 10");
            string antwoord = Console.ReadLine();
            return antwoord = Console.ReadLine();
        }
    }
}

