try
{
    string source = @"c:\temp\file1";
    
    using (StreamReader sr = File.OpenText(source))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    System.Console.WriteLine("An error occurred...");
    System.Console.WriteLine(e.Message);
}