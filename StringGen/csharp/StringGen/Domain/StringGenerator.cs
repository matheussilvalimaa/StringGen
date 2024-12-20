using System;

namespace StringGen.Domain
{
    //Uses a Random generator to produce a string composed of characters from a given set.
    public class StringGenerator : IStringGenerator
    {
        public string GenerateString(string characterSet, int length)
        {
            var random = new Random();
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characterSet.Length);
                result[i] = characterSet[index];
            }
            return new string(result);
        }
    }
}
