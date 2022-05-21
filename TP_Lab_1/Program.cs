using System;

namespace TP_Lab_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            TruncatedPyramid pyr1 = new TruncatedPyramid(3.0, 5.0, 4.0);
            double vPyr1 = pyr1.Volume();
            TruncatedPyramid pyr2 = new TruncatedPyramid(3.0, 5.0, 60.0f);
            double sPyr2 = pyr2.SideSurf();
            Console.WriteLine($"Объем пирамиды равен {vPyr1}, площадь боковой порвехности равна {sPyr2}");
            Vector vec1 = new Vector();
            vec1.A = double.Parse(Console.ReadLine()); 
            vec1.B = double.Parse(Console.ReadLine());
            string vec1Inf = vec1.Info();
            Console.WriteLine("Коодинаты ветора : " + vec1Inf);
            Vector vec2 = vec1.Norm();
            string vec2Inf = vec2.Info();
            Console.WriteLine("Коодинаты номированного ветора : " + vec2Inf); 
        }
    }
}
