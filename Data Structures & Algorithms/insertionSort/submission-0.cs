// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

//[4,3,2,1]
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> res = new List<List<Pair>>();
        for (int current = 0; current < pairs.Count; current++) {
            int previous = current - 1;
            while (previous >= 0 && pairs[previous].Key > pairs[previous + 1].Key) {
                Pair temp = pairs[previous];
                pairs[previous] = pairs[previous + 1];
                pairs[previous + 1] = temp;
                previous--;
            }
            res.Add(new List<Pair>(pairs));
        }
        return res;
    }
}
