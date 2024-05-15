using System;
using System.Collections.Generic;
using System.IO;

public class RunnerFile
{
    public static void PrintDocument(string root)
    {
        using (var handler = new FileHandler(root))
        {
            IList<string> lines = handler.Read();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }

    public static void Runner()
    {
        var root = "/home/fundacion/Documents/DesarolloSoftwareV/Claases/RepoOficial/DesarolloSoftware-5/15Mayo/archivo.txt";
        PrintDocument(root);
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        Runner();
    }
}

public class FileHandler : IDisposable
{
    public readonly string _root;
    private StreamReader _reader;

    public FileHandler(string root)
    {
        _root = root;
        _reader = new StreamReader(_root);
    }

    public IList<string> Read()
    {
        var lines = new List<string>();
        string line;
        while ((line = _reader.ReadLine()) != null)
        {
            lines.Add(line);
        }
        return lines;
    }

    public void Dispose()
    {
        if (_reader != null)
        {
            _reader.Close();
            _reader.Dispose();
            _reader = null;
        }
    }
}
