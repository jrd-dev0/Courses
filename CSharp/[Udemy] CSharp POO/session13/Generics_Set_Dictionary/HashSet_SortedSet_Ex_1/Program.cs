using HashSet_SortedSet_Ex_1.Entities;
using System.Xml.Schema;

namespace HashSet_SortedSet_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter file full path (ex.: c:\temp\test.txt): ");
            string path = Console.ReadLine();

            HashSet<UserLog> set = new HashSet<UserLog>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(' ');
                        string name = vet[0];
                        DateTime accessTime = DateTime.Parse(vet[1]);
                        set.Add(new UserLog(name, accessTime));
                    }

                    Console.WriteLine($"Total users: {set.Count}");
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