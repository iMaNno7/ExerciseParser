namespace Domain
{
    public class String
    {
        public static string[] Separator(string text, char separator)
        {
            if (separator == char.MinValue)
                throw new EmptySeparatorException();
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

    }
}