using System;
using System.Security.Cryptography;

namespace StringGen.Domain
{
    //Uses a Random generator to produce a string composed of characters from a given set.
    public class StringGenerator
    {
        public string GenerateString(string characterSet, int length)
        {
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                int index = RandomNumberGenerator.GetInt32(characterSet.Length);
                result[i] = characterSet[index];
            }
            return new string(result);
        }
    }
}
