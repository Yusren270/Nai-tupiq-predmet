using System;
using System.Collections.Generic;
using System.Text;

namespace Hristograma
{
    public class Model
    {
        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private double p1;
        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        private double p2;
        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        private double p3;
        public double P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        private double p4;
        public double P4
        {
            get { return p4; }
            set { p4 = value; }
        }
        private double p5;
        public double P5
        {
            get { return p5; }
            set { p5 = value; }
        }
        public void Calculate()
        {
            for (int i = 0; i < Num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if (number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
        }
    }
}

