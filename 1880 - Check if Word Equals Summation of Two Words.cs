/*
Problem 1880:
The letter value of a letter is its position in the alphabet starting from 0 (i.e. 'a' -> 0, 'b' -> 1, 'c' -> 2, etc.).
The numerical value of some string of lowercase English letters s is the concatenation of the letter values of each letter in s, which is then converted into an integer.
For example, if s = "acb", we concatenate each letter's letter value, resulting in "021". After converting it, we get 21.
You are given three strings firstWord, secondWord, and targetWord, each consisting of lowercase English letters 'a' through 'j' inclusive.
Return true if the summation of the numerical values of firstWord and secondWord equals the numerical value of targetWord, or false otherwise.
*/

public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        string s1 = "", s2 = "", s3 = "";
        
        for (int i = 0; i < firstWord.Length; i++) {
            s1 += firstWord[i]-'a';
        }
        for (int i = 0; i < secondWord.Length; i++) {
            s2 += secondWord[i]-'a';
        }
        for (int i = 0; i < targetWord.Length; i++) {
            s3 += targetWord[i]-'a';
        }
        
        int i1 = int.Parse(s1);
        int i2 = int.Parse(s2);
        int i3 = int.Parse(s3);
        
        return (i1 + i2 == i3);
    }
}
