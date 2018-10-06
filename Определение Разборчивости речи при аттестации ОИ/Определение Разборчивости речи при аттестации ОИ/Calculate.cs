using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Определение_Разборчивости_речи_при_аттестации_ОИ
{

   
        class Calculate
        {


            double q1 = 0, q2 = 0, q3 = 0, q4 = 0, q5 = 0, q6 = 0, q7 = 0;
            double Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, Q5 = 0, Q6 = 0, Q7 = 0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0;
            double R, R1 = 0, R2 = 0, R3 = 0, R4 = 0, R5 = 0, R6 = 0, R7 = 0;
            double p = 0;

            public double calculateP(double Q)
            {
                if (Q <= 0)
                {
                    p = (0.78 + 5.46 * Math.Exp(-4.3 * Math.Pow(10, -3) * Math.Pow(27.3 - Math.Abs(Q), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q)));
                }
                else
                {
                    p = 1 - (0.78 + 5.46 * Math.Exp(-4.3 * Math.Pow(10, -3) * Math.Pow(27.3 - Math.Abs(Q), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q)));
                }
                return p;
            }

        public double Calculateq(double LT, double LC1, double LC2, double LSH)
        {
            double q = LT - LC1 + LC2 - LSH;
            return q;
        }


        public double CalculateFirst(double LT1, double LT2, double LT3, double LT4, double LT5, double LT6, double LT7, double LC11, double LC12, double LC13, double LC14, double LC15, double LC16, double LC17, double LC21, double LC22, double LC23, double LC24, double LC25, double LC26, double LC27, double LSH1, double LSH2, double LSH3, double LSH4, double LSH5, double LSH6, double LSH7)
            {
                q1 = Calculateq(LT1, LC11, LC21, LSH1);
                q2 = Calculateq(LT2, LC12, LC22, LSH2);
                q3 = Calculateq(LT3, LC13, LC23, LSH3);
                q4 = Calculateq(LT4, LC14, LC24, LSH4);
                q5 = Calculateq(LT5, LC15, LC25, LSH5);
                q6 = Calculateq(LT6, LC16, LC26, LSH6);
                q7 = Calculateq(LT7, LC17, LC27, LSH7);

                Q1 = q1 - 25;
                Q2 = q2 - 18;
                Q3 = q3 - 14;
                Q4 = q4 - 9;
                Q5 = q5 - 6;
                Q6 = q6 - 5;
                Q7 = q7 - 4;

                p1 = calculateP(Q1);
                p2 = calculateP(Q2);
                p3 = calculateP(Q3);
                p4 = calculateP(Q4);
                p5 = calculateP(Q5);
                p6 = calculateP(Q6);
                p7 = calculateP(Q7);

                R1 = p1 * 0.01;
                R2 = p2 * 0.03;
                R3 = p3 * 0.12;
                R4 = p4 * 0.20;
                R5 = p5 * 0.30;
                R6 = p6 * 0.26;
                R7 = p7 * 0.07;

                R = R1 + R2 + R3 + R4 + R5 + R6 + R7;

                return R;
            }

        public double CalculateSecond(double R)
        {
            double W = 0;
            if (R < 0.15)
            {
                W = 1.54 * Math.Pow(R, 0.25) * (1 - Math.Exp(-11 * R));
            }
            else
            {
                W = 1 - Math.Exp(-1 * (11 * R) / (1 + (0.7 * R)));
            }

            return W;
        }
    }
}