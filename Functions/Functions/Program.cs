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
            Console.WriteLine("Dit is mijn program"); //De function is Writeline en type is void
        }
    }
}

