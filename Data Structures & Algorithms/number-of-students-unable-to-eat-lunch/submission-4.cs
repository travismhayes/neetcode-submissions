public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int remaningSandsandwiches = 0;

        foreach (int student in students) {
            if (map.ContainsKey(student)) {
                map[student]++;
            } else {
                map[student] = 1;
            }
        }

        foreach(int sandwich in sandwiches) {
            if (map.ContainsKey(sandwich) && map[sandwich] > 0) {
                map[sandwich]--;
            } else {
                break;
            }
        }

        foreach (int count in map.Values) {
            remaningSandsandwiches += count;
        }

        return remaningSandsandwiches;
    }
}