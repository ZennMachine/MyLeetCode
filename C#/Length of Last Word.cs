public class Solution {
    public int LengthOfLastWord(string s) {
        string trimmedString = s.Trim();
        char[] delimiterChars = { ' ', ',', '.' };
        string[] words = trimmedString.Split(delimiterChars);
        string lastWord = words[words.Length -1];
        int lengthOfWord = 0;
        foreach(char c in lastWord)
        {
            lengthOfWord++;
        }

        return lengthOfWord;
    }
}