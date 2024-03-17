namespace Method4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzunluq daxil edin:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eni daxil edin:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hundurluk daxil edin:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Radius daxil edin:");
            int radius = Convert.ToInt32(Console.ReadLine());
            
            Area(radius);
            Area(length, width );
            Area(length,width, height );
            Area(radius, length, width, height);
            
        }
        
        static void Area(int r)
        {
            int p = 3;
            int circleArea = p * r*r;
            Console.WriteLine("Cevrenin sahesi:" +circleArea);
        }

        static void Area(int l, int w)
        {
            int rectangleArea = l * w;
            Console.WriteLine("Duzbucaqlini sahesi:" +  rectangleArea);
        }
        static void Area(int l, int w, int h)
        {
            int rectangleParelepipedArea = 2 * (l*w + l*h + w*h);
            Console.WriteLine("Duzbucaqli paralelpipedin tam sethinin sahesi:" + rectangleParelepipedArea);
        }
        static void Area(int r, int l, int w, int h)
        {
            int p = (l + w + h) / 2;
            int S = p * r;
            Console.WriteLine("Ucbucaqin daxiline cekilmis cevrenin sahesi:" + S);
        }
    }
}
