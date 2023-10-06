using System.Net.NetworkInformation;
using System.IO;
namespace IOfromTxtFile;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\46708\\repos\\IOfromTxtFile\\Test.txt";

        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.ReadLine();

    }
}

