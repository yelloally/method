

class Program
{
    // create a method which will contain all the informatiom for measuring the perimeter of the triangle
    static int Perimeter(int a, int b, int c)
    {
        int result = a + b + c;
        return result;
    }

    //our MAIN method  
    static void Main(string[] args)
    {
        int a, b, c, perim;

        //output which will paste user 
        Console.WriteLine("Paste 3 sights of triangle: ");

        //convert to 32-bit int
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        //calling our method
        perim = Perimeter(a, b, c);

        //resultttt
        Console.WriteLine("Perimetr is: " + perim);

    }
}