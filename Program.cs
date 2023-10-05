using System.Net.NetworkInformation;

namespace IOfromTxtFile;

class Program
{
    static void Main(string[] args)
    {
        

        //string[] lines = File.ReadAllLines(filePath);

        List<string> lines = new List<string>();
        lines = File.ReadAllLines("../../../Test.txt").ToList();
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        lines.Add("John, DOes, www.nobody.com");
        File.WriteAllLines("../../../Test.txt", lines);

        Console.ReadLine();

    }
}

