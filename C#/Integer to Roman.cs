// https://leetcode.com/problems/integer-to-roman/submissions/1222729361

public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        string romanNum = "";

        foreach(var item in numerals)
        {
            if(num <= 0)
                break;
            while(num >= item.Key)
            {
                romanNum += item.Value;
                num -= item.Key;
            }
        }
        return romanNum.ToString();
    }
}