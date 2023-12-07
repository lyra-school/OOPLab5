namespace ExtensionMethods
{
    public static class ExtensionA
    {
        public static int CharacterCount(this string s)
        {
            string[] words = s.Split(' ');
            return words.Length;
        }
    }
}