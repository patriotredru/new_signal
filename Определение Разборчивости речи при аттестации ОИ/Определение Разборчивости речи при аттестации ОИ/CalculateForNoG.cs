using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Определение_Разборчивости_речи_при_аттестации_ОИ
{
    // Тестовый комментарий
    class CalculateForNoG
    {

        double q2 = 0, q3 = 0, q4 = 0, q5 = 0, q6 = 0;
        double Q2 = 0, Q3 = 0, Q4 = 0, Q5 = 0, Q6 = 0;
        double p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0;
        double R, R2 = 0, R3 = 0, R4 = 0, R5 = 0, R6 = 0;
        double p = 0;

        public double calculatePNoG(double Q)
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

        public double CalculateqNoG(double LT, double LC1, double LC2, double LSH)
        {
            double q = 0;
            q = LT - LC1 + LC2 - LSH;
            return q;
        }

        
        public double CalculateFirstNoG(double LT2, double LT3, double LT4, double LT5, double LT6, double LC12, double LC13, double LC14, double LC15, double LC16, double LC22, double LC23, double LC24, double LC25, double LC26, double LSH2, double LSH3, double LSH4, double LSH5, double LSH6)
        {
            
            q2 = CalculateqNoG(LT2, LC12, LC22, LSH2);
            q3 = CalculateqNoG(LT3, LC13, LC23, LSH3);
            q4 = CalculateqNoG(LT4, LC14, LC24, LSH4);
            q5 = CalculateqNoG(LT5, LC15, LC25, LSH5);
            q6 = CalculateqNoG(LT6, LC16, LC26, LSH6);

            Q2 = q2 - 18;
            Q3 = q3 - 14;
            Q4 = q4 - 9;
            Q5 = q5 - 6;
            Q6 = q6 - 5;

            p2 = calculatePNoG(Q2);
            p3 = calculatePNoG(Q3);
            p4 = calculatePNoG(Q4);
            p5 = calculatePNoG(Q5);
            p6 = calculatePNoG(Q6);
            
            R2 = p2 * 0.03;
            R3 = p3 * 0.12;
            R4 = p4 * 0.20;
            R5 = p5 * 0.30;
            R6 = p6 * 0.26;

            R = R2 + R3 + R4 + R5 + R6;

            return R;
        }

        public double CalculateSecondNoG(double R)
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
