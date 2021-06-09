public class Solution {
    public string DefangIPaddr(string address) {
        string[] splitStrings = address.Split('.');

        for (int i = 0; i < 3; i++) {
            splitStrings[i] += "[.]";
        }

        return splitStrings[0] + splitStrings[1] + splitStrings[2] + splitStrings[3];
    }
}