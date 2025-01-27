namespace Dictionaries
{
    internal class Program
    {
        internal void Run() 
        {
            
        }
        Dictionary<string,Room> rooms = new Dictionary<string,Room>();
        static void Main(string[] args)
        {
            Program program = new Program(); //Program is de function en Run is het return type 
            program.Run(); //een class die je moet oproepen

            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

            personeelOpNummer.Add(304954, "Jim");
            personeelOpNummer.Add(239478, "Tim");

            string Jim = personeelOpNummer[304954];
            string Tim = personeelOpNummer[239478];

            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);

            }

            foreach (int key in personeelOpNummer.Keys)
            {

            }
            foreach (string key in personeelOpNummer.Values)
            {

            }

            Room start = new Room(0, 0, [
        "xxxxxx",
        "x....x",
        "x....x",
        "x....x",
        "xxxxxx",
     ]);
        }
       
    }
}
