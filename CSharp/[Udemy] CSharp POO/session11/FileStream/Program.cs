string source = @"c:\temp\file1";

try
{
    using (FileStream fs = new FileStream(source, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
catch (IOException e)
{
    System.Console.WriteLine("An error occurred...");
    System.Console.WriteLine(e.Message);
}
