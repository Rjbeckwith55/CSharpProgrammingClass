using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double score;
            int scale;
            Console.WriteLine("Input your average grade");
            score = Convert.ToDouble(Console.ReadLine());
            scale = QualityPoints(score);
            Console.WriteLine("Your GPA is: "+scale);
        }
        static int QualityPoints(double score)
        {
            if (score >= 90)
                return 4;
            else if (score < 90 && score >= 80)
                return 3;
            else if (score < 80 && score >= 70)
                return 2;
            else if (score < 70 && score >= 60)
                return 1;
            else
                return 0;

        }

    }
}
