/* Raphael Lopes, Anthony Chevrolet
 * Test intergrity
 * 13.02.2019
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQIntergrity
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] oneKo = GetMemeoryOfFile("1ko.txt");
            byte[] tenKo = GetMemeoryOfFile("10ko.txt");
            byte[] hundredKo = GetMemeoryOfFile("100ko.txt");
            byte[] test = GetMemeoryOfFile("100ko.txt");
            
            Console.WriteLine(Convert.ToString(CheckMessageIntegrity(hundredKo, test)));
        } 
        /// <summary>
        /// this function will get the memory of the file
        /// </summary>
        /// <param name="filename">name of the file</param>
        /// <returns>memory value</returns>
        private static byte[] GetMemeoryOfFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                using (var memstream = new MemoryStream())
                {
                    sr.BaseStream.CopyTo(memstream);
                    return memstream.ToArray();
                }
            }
     
        }
        /// <summary>
        /// this will compare two byte array 
        /// </summary>
        /// <param name="one">first array</param>
        /// <param name="two">second array</param>
        /// <returns>true if the byte array are the same otherwise false</returns>
        public static bool CheckMessageIntegrity(byte[] one,byte[] two)
        {
            if(one.Length != two.Length)
            {
                return false;
            }
            for (int i = 0; i < one.Length; i++)
            {
                if(one[i] != two[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
