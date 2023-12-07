namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aaa aaa aaa aaa";
            string s2 = "The quick brown fox jumps over the lazy dog.";

            Console.WriteLine(s1.CharacterCount());
            Console.WriteLine(s2.CharacterCount());
        }
    }
}