namespace Dictionary_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(@"Enter file full path (ex.: c:\temp\test.txt): ");
                string path = Console.ReadLine();

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(',');
                        string name = vet[0];
                        int votes = int.Parse(vet[1]);

                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += votes;
                        }
                        else
                        {
                            dictionary[name] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}