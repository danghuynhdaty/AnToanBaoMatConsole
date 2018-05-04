using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnToanBaoMatConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ceasar

            //Console.Write("Type a string to encrypt: ");
            //string userInput = Console.ReadLine();

            //Console.Write("\n");

            //Console.Write("Enter your key: ");
            //int key = int.Parse(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Encrypted Data");
            //string cipherText = Ceasar.Encipher(userInput, key);
            //Console.WriteLine(cipherText);

            //Console.Write("\n");

            //Console.WriteLine("Decrypted Data:");

            //string plainText = Ceasar.Decipher(cipherText, key);
            //Console.WriteLine(plainText);

            //Console.Write("\n");

            #endregion Ceasar

            #region Playfair

            string originalText = "dang thi truc phuong";
            Console.WriteLine(originalText);
            string plainText = Playfair.Prepare(originalText);
            Console.WriteLine(plainText);
            string key = "playfirexmbcdghjknostuvwz";
            string cipherText = Playfair.Encipher(key, plainText);
            Console.WriteLine(cipherText);
            plainText = Playfair.Decipher(key, cipherText);
            Console.WriteLine(plainText);
            Console.WriteLine();


            originalText = "Hide the gold in the tree stump.";
            Console.WriteLine(originalText);
            plainText = Playfair.Prepare(originalText);
            Console.WriteLine(plainText);
            key = "playfirexmbcdghjknostuvwz";
            cipherText = Playfair.Encipher(key, plainText);
            Console.WriteLine(cipherText);
            plainText = Playfair.Decipher(key, cipherText);
            Console.WriteLine(plainText);

            #endregion Playfair

            Console.ReadKey();
        }
    }
}
