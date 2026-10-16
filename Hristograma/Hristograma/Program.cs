namespace Hristograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //double p1 = 0;
            //double p2 = 0;
            //double p3 = 0;
            //double p4 = 0;
            //double p5 = 0;
            //for(int i=0;i<n;i++)
            //{
            // int number = int.Parse(Console.ReadLine());
            // if (number<200)
            // {
            // p1++;
            // }
            // else if(number<400)
            // {
            // p2++;
            // }
            // else if(number<600)
            // {
            // p3++;
            // }
            // else if(number<800)
            // {
            // p4++;
            // }
            // else
            // {
            // p5++;
            // }

            //}
            //Console.WriteLine($"{p1*100/n:F2}%");
            //Console.WriteLine($"{p2*100/n:F2}%");
            //Console.WriteLine($"{p3*100/n:F2}%");
            //Console.WriteLine($"{p4*100/n:F2}%");
            //Console.WriteLine($"{p5*100/n:F2}%");

            Controller controller = new Controller();
            controller.Start();
        }
    }
}
