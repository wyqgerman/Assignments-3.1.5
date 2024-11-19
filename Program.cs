namespace Assignments_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 2, 1, 1, 9, 1, 1 };
            Console.WriteLine("Original Array: [" + string.Join(", ", inputArray) + "]");

            ModifyArray(inputArray);

            Console.WriteLine("Modified Array: [" + string.Join(", ", inputArray) + "]");
        }

        static void ModifyArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 1) 
                {
                    arr[i] = 0;
                    arr[i + 1] = 0;
                    break; 
                }
            }
        }
    }
}
