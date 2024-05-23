namespace Week_3_Challenge_Labs_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Indicies([2, 7, 11, 15], 9));

            static string Indicies(int[] myArray, int target) 
            {
                int leftPointer = 0;
                int rightPointer = myArray.Length-1;
                while (leftPointer < rightPointer) 
                {
                    int addition = myArray[leftPointer] + myArray[rightPointer];
                    
                    if (addition == target) 
                    {
                        return $"[{leftPointer},{rightPointer}]";
                    }
                    else if (addition > target) 
                    {
                        rightPointer--;
                    }
                    else
                    {
                        leftPointer++;    
                    }   
                }
                return "none";
            }
        }
    }
}
