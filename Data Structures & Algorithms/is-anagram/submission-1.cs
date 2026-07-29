public class Solution {
    public bool IsAnagram(string s, string t) {
        // My first thought is if I just sorted the strings I could just do a ssingle loop and compare
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();

        if (sArr.Length != tArr.Length) return false;

        Array.Sort(sArr);
        Array.Sort(tArr);

        for (int i = 0; i < s.Length; i++) {
            if (sArr[i] != tArr[i]) {
                return false;
            }
        }
        return true;
    }   
}
