namespace Warmup
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int total1 = 0;
            int total2 = 0;
            for (int i = 0; i < a.Count; i++)
            { 
                if (a[i] > b[i])
                    total1++;
                else if (b[i] > a[i])
                    total2++;
            }
            return new List<int> { total1, total2 };
        }
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;
            foreach (long n in ar)
            {
                result += n;
            }
            return result;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumPrimDiag = 0;
            int sumSecDiag = 0;
            int size = arr.Count - 1;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                        sumPrimDiag += arr[i][j];
                    if (j == size)
                    {
                        sumSecDiag += arr[i][j];
                        --size;
                    }
                }
            }
            return Math.Abs(sumSecDiag + sumPrimDiag);
        }
    }
}
