namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 9, 5, 2};
            int[] arr2 = { 5, 7, 11, 12,13};

            MultipiliedNumbers(arr, arr2);

        }

        static void MultipiliedNumbers(int[] a, int[] b) 
        {
            int arrLength = a.Length;
            int[] arr = new int[arrLength] ;
            if (a.Length == b.Length) 
            {
                for (int i = 0; i < a.Length; i++)
                {
                    arr[i] += a[i];
                    
                }
                for(int i  = 0; i < b.Length; i++)
                {
                    arr[i] *= b[i];
                    Console.WriteLine(arr[i]);
                }
            }
            else if (a.Length != b.Length)
            {
                Console.WriteLine("Siyahilarin uzunluqlari eyni deyil");
            }
            
           
        }
    }
}
