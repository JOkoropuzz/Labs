
using System;                
using System.IO;
using System.Runtime.Remoting.Contexts;

class FileDetails 
{
    public static void Summarize(char[] x)
    {
        int vowels = 0, consonants = 0, lines = 0;
        foreach (char current in x)
        {
            if (Char.IsLetter(current))
            {
                if ("AEIOUaeiou".IndexOf(current) != -1)
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            else if (current == '\n')
            {
                lines++;
            }
        }
        Console.WriteLine("Total no of characters: {0}",
        x.Length);
        Console.WriteLine("Total no of vowels : {0}", vowels);
        Console.WriteLine("Total no of consonants: {0}",
        consonants);
        Console.WriteLine("Total no of lines : {0}", lines);
    }
    static void Main(string[] args)
    {
        string fileName = args[0];
        FileStream stream = new FileStream(fileName,
        FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        int size = (int)stream.Length;
        char[] contents = new char[size];
        for (int i = 0; i < size; i++)
        {
            contents[i] = (char)reader.Read();
        }
        FileDetails.Summarize(contents);
        /*
        foreach (char ch in contents)
        {
            Console.Write(ch);
        }
        Console.ReadLine();
        */
        reader.Close();
    }
}
