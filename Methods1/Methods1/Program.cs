namespace Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "fuad", "arif", "adil", "elmir" };
            string[] arr2 = { "zaman", "fuad", "vasif" };
            SameNames(arr, arr2);

        }
        static void SameNames(string[] a, string[] b)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.Write(a[i]);
                        c = 1;
                        break;


                    }


                }
            }


            if (c == 0)
            {

                Console.WriteLine("Ortaq ad yoxdu");
                

            }
        }
    }    
}
