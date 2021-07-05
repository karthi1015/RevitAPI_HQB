using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AlphaBIM
{
    public class Ptbh
    {
        public double a, b, c;
        //public double b;
        //public double c;

        public void NghiemCuaPtbh()
        {
            double nghiem1;
            double nghiem2;

            double DenTa = (b * b) - 4 * a * c;

            if (DenTa == 0)

            {
                nghiem1 = nghiem2 = -b / (2 * a);

                MessageBox.Show("Phương trình có 2 nghiệm:" + "\n" +
                                "x1 = " + nghiem1.ToString() + "\n" +
                                "x2 = " + nghiem2.ToString());
            }
            else if (DenTa > 0)
            {
                nghiem1 = (-b - Math.Sqrt(DenTa)) / (2*a);

                nghiem2 = (-b + Math.Sqrt(DenTa)) / (2*a);

                MessageBox.Show("Phương trình có 2 nghiệm:" + "\n" +
                                "x1 = " + nghiem1.ToString() + "\n" +
                                "x2 = " + nghiem2.ToString());

            }
            else
            {
                MessageBox.Show("Phương trình vô nghiệm");
            }
            
                
            
        }
    }
}