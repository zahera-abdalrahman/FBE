using System;
using System.IO;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:\\Orange Coding School\\Asp.net\\Tasks Solution\\write read files.txt";

            string[] information = {
            "Name: Zahera Alakash",
            "Specialization: Software Engineer",
            "Age: I'm 22",
            "Description: I'm Asp.net developer"
        };


            File.WriteAllLines(filePath, information);


            //Read from a file
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //Number of characters
            Console.WriteLine("Number of characters: "+countCharacters());
            //Number of words
            Console.WriteLine("Number of words: " + countWords());

        }

        public static int countCharacters()
        {
            int characters = 0;
            using (StreamReader reader = new StreamReader("E:\\Orange Coding School\\Asp.net\\Tasks Solution\\write read files.txt"))
            {
                string content = reader.ReadToEnd();
                characters = content.Length;
            }
            return characters;
        }


        public static int countWords()
        {
            int words = 0;
            using (StreamReader reader = new StreamReader("E:\\Orange Coding School\\Asp.net\\Tasks Solution\\write read files.txt"))
            {
                string content = reader.ReadToEnd();
                string[] wordCounter = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                words = wordCounter.Length;
            }
            return words;
        }
    }
}
