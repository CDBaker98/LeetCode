/*
Problem 1108:
Given a valid (IPv4) IP address, return a defanged version of that IP address.
A defanged IP address replaces every period "." with "[.]".
*/

public class Solution {
    public string DefangIPaddr(string address) {
        string[] splitStrings = address.Split('.');

        for (int i = 0; i < 3; i++) {
            splitStrings[i] += "[.]";
        }

        return splitStrings[0] + splitStrings[1] + splitStrings[2] + splitStrings[3];
    }
}