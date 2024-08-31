namespace Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var degrees = gradingStudents(new List<int>() { 45, 56, 78, 69, 57 });
            for (int i = 0; i < degrees.Count; i++)
            {
                Console.WriteLine(degrees[i]);
            }
            Console.WriteLine("Hello, World!");
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38 && (grades[i] / 5 + 1) * 5 - grades[i] < 3)
                {
                    grades[i] = (grades[i] / 5 + 1) * 5;
                }
            }
            return grades;
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int samApples = 0, samOranges = 0;
            foreach (var apple in apples)
            {
                if(apple > 0)
                {
                    int dist = apple + a;
                    if (dist > s && dist < t)
                        samApples++;
                }
            }
            foreach (var orange in oranges)
            {
                if(orange < 0)
                {
                    int dist = orange + b;
                    if (dist > s && dist < t)
                        samOranges++;
                }
            }
            Console.WriteLine(samApples);
            Console.WriteLine(samOranges);
        }
        public static List<int> reverseArray(List<int> a)
        {
            a.Reverse();
            return a;
        }
    }
}
