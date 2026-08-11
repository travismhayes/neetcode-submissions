public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int student in students)
        {
            map[student] = map.GetValueOrDefault(student) + 1;
        }

        foreach (int sandwich in sandwiches)
        {
            if (map.GetValueOrDefault(sandwich) > 0)
            {
                map[sandwich]--;
            }
            else
            {
                break;
            }
        }

        return map.Values.Sum();
    }
}