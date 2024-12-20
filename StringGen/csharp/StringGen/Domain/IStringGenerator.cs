namespace StringGen.Domain
{
    //Defines a contract for generating a string given a character set and a length.
    public interface IStringGenerator
    {
        string GenerateString(string characterSet, int length);
    }
}
