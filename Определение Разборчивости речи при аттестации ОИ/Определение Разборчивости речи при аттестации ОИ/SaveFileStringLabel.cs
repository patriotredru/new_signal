using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Определение_Разборчивости_речи_при_аттестации_ОИ
{
    class SaveFileStringLabel
    {
        public string ConvertToStringSaveFile(
            decimal Lt_1, decimal Lt_2, decimal Lt_3, decimal Lt_4, decimal Lt_5, decimal Lt_6, decimal Lt_7,
            decimal Lc1_1, decimal Lc1_2, decimal Lc1_3, decimal Lc1_4, decimal Lc1_5, decimal Lc1_6, decimal Lc1_7,
            decimal Lc2_1, decimal Lc2_2, decimal Lc2_3, decimal Lc2_4, decimal Lc2_5, decimal Lc2_6, decimal Lc2_7,
            decimal Lsh_1, decimal Lsh_2, decimal Lsh_3, decimal Lsh_4, decimal Lsh_5, decimal Lsh_6, decimal Lsh_7,
            decimal Ractic, decimal calculateDecision
            )
        {
            string AnswerString = "";

            AnswerString = 
                          "Октавная полоса №1" + " Lt_1:  " + Convert.ToString(Lt_1) + " " + "        Lc1_1:" + Convert.ToString(Lc1_1) + " " + "       Lc2_1:" + Convert.ToString(Lc2_1) + " " + "       Lsh_1:" + Convert.ToString(Lsh_1) + " " + "\r\n"
                        + "Октавная полоса №2" + " Lt_2:  " + Convert.ToString(Lt_2) + " " + "        Lc1_2:" + Convert.ToString(Lc1_2) + " " + "       Lc2_2:" + Convert.ToString(Lc2_2) + " " + "       Lsh_2:" + Convert.ToString(Lsh_2) + " " + "\r\n"
                        + "Октавная полоса №3" + " Lt_3:  " + Convert.ToString(Lt_3) + " " + "        Lc1_3:" + Convert.ToString(Lc1_3) + " " + "       Lc2_3:" + Convert.ToString(Lc2_3) + " " + "       Lsh_3:" + Convert.ToString(Lsh_3) + " " + "\r\n"
                        + "Октавная полоса №4" + " Lt_4:  " + Convert.ToString(Lt_4) + " " + "        Lc1_4:" + Convert.ToString(Lc1_4) + " " + "       Lc2_4:" + Convert.ToString(Lc2_4) + " " + "       Lsh_4:" + Convert.ToString(Lsh_4) + " " + "\r\n"
                        + "Октавная полоса №5" + " Lt_5:  " + Convert.ToString(Lt_5) + " " + "        Lc1_5:" + Convert.ToString(Lc1_5) + " " + "       Lc2_5:" + Convert.ToString(Lc2_5) + " " + "       Lsh_5:" + Convert.ToString(Lsh_5) + " " + "\r\n"
                        + "Октавная полоса №6" + " Lt_6:  " + Convert.ToString(Lt_6) + " " + "        Lc1_6:" + Convert.ToString(Lc1_6) + " " + "       Lc2_6:" + Convert.ToString(Lc2_6) + " " + "       Lsh_6:" + Convert.ToString(Lsh_6) + " " + "\r\n"
                        + "Октавная полоса №7" + " Lt_7:  " + Convert.ToString(Lt_7) + " " + "        Lc1_7:" + Convert.ToString(Lc1_7) + " " + "       Lc2_7:" + Convert.ToString(Lc2_7) + " " + "       Lsh_7:" + Convert.ToString(Lsh_7) + " " + "\r\n"
                        + "\r\n" + "\r\n" + "\r\n"

                        + "Ответы:" + "\r\n"
                        + "Интегральный индекс артикуляции R равен: " + Convert.ToString(Ractic) + "\r\n"
                        + "Уровень разборчивости речи W равен: " + Convert.ToString(calculateDecision) + "\r\n";
            return AnswerString;
        }

        public string ConvertToStringSaveFileNoG(
            decimal Lt_2, decimal Lt_3, decimal Lt_4, decimal Lt_5, decimal Lt_6,
            decimal Lc1_2, decimal Lc1_3, decimal Lc1_4, decimal Lc1_5, decimal Lc1_6,
            decimal Lc2_2, decimal Lc2_3, decimal Lc2_4, decimal Lc2_5, decimal Lc2_6,
            decimal Lsh_2, decimal Lsh_3, decimal Lsh_4, decimal Lsh_5, decimal Lsh_6,
            decimal Ractic, decimal calculateDecision
            )
        {
            string AnswerString = "";

            AnswerString =
                          "Октавная полоса №1" + " Lt_1:  " + Convert.ToString(Lt_2) + " " + "        Lc1_1:" + Convert.ToString(Lc1_2) + " " + "       Lc2_1:" + Convert.ToString(Lc2_2) + " " + "       Lsh_1:" + Convert.ToString(Lsh_2) + " " + "\r\n"
                        + "Октавная полоса №2" + " Lt_2:  " + Convert.ToString(Lt_3) + " " + "        Lc1_2:" + Convert.ToString(Lc1_3) + " " + "       Lc2_2:" + Convert.ToString(Lc2_3) + " " + "       Lsh_2:" + Convert.ToString(Lsh_3) + " " + "\r\n"
                        + "Октавная полоса №3" + " Lt_3:  " + Convert.ToString(Lt_4) + " " + "        Lc1_3:" + Convert.ToString(Lc1_4) + " " + "       Lc2_3:" + Convert.ToString(Lc2_4) + " " + "       Lsh_3:" + Convert.ToString(Lsh_4) + " " + "\r\n"
                        + "Октавная полоса №4" + " Lt_4:  " + Convert.ToString(Lt_5) + " " + "        Lc1_4:" + Convert.ToString(Lc1_5) + " " + "       Lc2_4:" + Convert.ToString(Lc2_5) + " " + "       Lsh_4:" + Convert.ToString(Lsh_5) + " " + "\r\n"
                        + "Октавная полоса №5" + " Lt_5:  " + Convert.ToString(Lt_6) + " " + "        Lc1_5:" + Convert.ToString(Lc1_6) + " " + "       Lc2_5:" + Convert.ToString(Lc2_6) + " " + "       Lsh_5:" + Convert.ToString(Lsh_6) + " " + "\r\n"
                        + "\r\n" + "\r\n" + "\r\n"

                        + "Ответы:" + "\r\n"
                        + "Интегральный индекс артикуляции R равен: " + Convert.ToString(Ractic) + "\r\n"
                        + "Уровень разборчивости речи W равен: " + Convert.ToString(calculateDecision) + "\r\n";
            return AnswerString;
        }

    }
}
