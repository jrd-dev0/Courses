using System.IO;

string source = @"c:\windows\system32\drivers\etc\hosts";
string destiny = @"c:\temp\FileSource.bkp";

try 
{   
    // get source file and backup it on destiny folder
    FileInfo file = new FileInfo(source);
    file.CopyTo(destiny);

    // get source file then show his content 
    string[] hostFile = File.ReadAllLines(source);

    foreach (string line in hostFile)
    {
        Console.WriteLine(line);
    }

}
catch (IOException e )
{
    Console.WriteLine("Ocorreu um erro");
    Console.WriteLine(e.Message);
}

Console.ReadLine();