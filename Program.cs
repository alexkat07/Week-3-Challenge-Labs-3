namespace Week_3_Challenge_Labs_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Indicies([2, 7, 11, 15], 9));

            static string Indicies(int[] myArray, int target) 
            {
                int L = 0;
                int R = myArray.Length-1;
                while (L < R) 
                {
                    int addition = myArray[L] + myArray[R];
                    if (addition == target) 
                    {
                        return $"[{L},{R}]";
                    }
                    else if (addition > target) 
                    {
                        R--;
                    }
                    else
                    {
                        L++;    
                    }   
                }
                return "none";
            }
        }
    }
}
