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
