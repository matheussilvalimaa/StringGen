namespace StringGen.Domain
{
    //Provides validation methods for the domain, such as string length validation.
    public static class Validations
    {
        public static bool IsValidLength(int length)
        {
            return length > 0 && length <= 1000;
        }
    }
}
