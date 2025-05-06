using System;
using StringGen.Domain;

namespace StringGen.Application
{
    //Orchestrates the use case of generating a string.
    public class StringGenerationService
    {
        private readonly StringGenerator _stringGenerator;

        public StringGenerationService()
        {
            _stringGenerator = new StringGenerator();
        }

        //Generates a string based on the selected option and length and validates the length.
        public string GenerateAndSaveString(int option, int length)
        {
            if (!Validations.IsValidLength(length))
            {
                throw new ArgumentException("Invalid size");
            }

            string characterSet = GetCharacterSet(option);
            string generated = _stringGenerator.GenerateString(characterSet, length);

            return generated;
        }

        // Returns the character set based on the user's chosen option.
        private string GetCharacterSet(int option)
        {
            switch (option)
            {
                case 1:
                    return CharacterSets.Uppercase;
                case 2:
                    return CharacterSets.Lowercase;
                case 3:
                    return CharacterSets.Digits;
                case 4:
                    return CharacterSets.Uppercase + CharacterSets.Lowercase + CharacterSets.Digits;
                case 5:
                    return CharacterSets.Uppercase + CharacterSets.Lowercase + CharacterSets.Digits + CharacterSets.Simbols;
                default:
                    throw new ArgumentException("Invalid option.");
            }
        }
    }
}
