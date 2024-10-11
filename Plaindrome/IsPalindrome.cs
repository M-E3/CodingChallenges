namespace PalindromeChecker
{
    public class IsPalindrome
    {
        public bool CheckString(string input)
        {
            bool result;

            var filterInput = input.ToLower().Replace(" ", "");
            char[] chars = filterInput.ToCharArray();

            chars = Array.FindAll<char>(chars, (c =>
            (char.IsLetter(c))));

            filterInput = new string(chars);

            var reverse = filterInput.Reverse();
            result = reverse.SequenceEqual(filterInput);

            return result;
        }

    }
}
