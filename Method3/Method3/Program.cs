namespace Method3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            string[] arr = { "Fuad", "Adil", "Zaman", "Murad", "Azer"};

            Names(arr, a);


        }
        static void Names(string[] arr, char a)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                    if(a == arr[i][0])
                    {
                        Console.WriteLine(arr[i]);
                         c = 1;
                        

                    }
                    
            }
            if (c == 0)
            {
                Console.WriteLine("Bu herfle baslayan soz yoxdur");
            }
        }
    }
}
