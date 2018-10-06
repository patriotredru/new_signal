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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetVisibility();
        }

        public double FillingDataR()
        {
            double LT1 = Convert.ToDouble(Lt_1.Value);
            double LT2 = Convert.ToDouble(Lt_2.Value);
            double LT3 = Convert.ToDouble(Lt_3.Value);
            double LT4 = Convert.ToDouble(Lt_4.Value);
            double LT5 = Convert.ToDouble(Lt_5.Value);
            double LT6 = Convert.ToDouble(Lt_6.Value);
            double LT7 = Convert.ToDouble(Lt_7.Value);

            double LC11 = Convert.ToDouble(Lc1_1.Value);
            double LC12 = Convert.ToDouble(Lc1_2.Value);
            double LC13 = Convert.ToDouble(Lc1_3.Value);
            double LC14 = Convert.ToDouble(Lc1_4.Value);
            double LC15 = Convert.ToDouble(Lc1_5.Value);
            double LC16 = Convert.ToDouble(Lc1_6.Value);
            double LC17 = Convert.ToDouble(Lc1_7.Value);

            double LC21 = Convert.ToDouble(Lc2_1.Value);
            double LC22 = Convert.ToDouble(Lc2_2.Value);
            double LC23 = Convert.ToDouble(Lc2_3.Value);
            double LC24 = Convert.ToDouble(Lc2_4.Value);
            double LC25 = Convert.ToDouble(Lc2_5.Value);
            double LC26 = Convert.ToDouble(Lc2_6.Value);
            double LC27 = Convert.ToDouble(Lc2_7.Value);

            double LSH1 = Convert.ToDouble(Lsh_1.Value);
            double LSH2 = Convert.ToDouble(Lsh_2.Value);
            double LSH3 = Convert.ToDouble(Lsh_3.Value);
            double LSH4 = Convert.ToDouble(Lsh_4.Value);
            double LSH5 = Convert.ToDouble(Lsh_5.Value);
            double LSH6 = Convert.ToDouble(Lsh_6.Value);
            double LSH7 = Convert.ToDouble(Lsh_7.Value);

            double R = GetRactic(LT1, LT2, LT3, LT4, LT5, LT6, LT7, LC11, LC12, LC13, LC14, LC15, LC16, LC17, LC21, LC22, LC23, LC24, LC25, LC26, LC27, LSH1, LSH2, LSH3, LSH4, LSH5, LSH6, LSH7);
            return R;
        }

        private static double GetRactic(double LT1, double LT2, double LT3, double LT4, double LT5, double LT6, double LT7, double LC11, double LC12, double LC13, double LC14, double LC15, double LC16, double LC17, double LC21, double LC22, double LC23, double LC24, double LC25, double LC26, double LC27, double LSH1, double LSH2, double LSH3, double LSH4, double LSH5, double LSH6, double LSH7)
        {
            Calculate calc = new Calculate();
            double R = calc.CalculateFirst(LT1, LT2, LT3, LT4, LT5, LT6, LT7, LC11, LC12, LC13, LC14, LC15, LC16, LC17, LC21, LC22, LC23, LC24, LC25, LC26, LC27, LSH1, LSH2, LSH3, LSH4, LSH5, LSH6, LSH7);
            return R;
        }

        public double FillingDataRNoG()
        {
            CalculateForNoG calcNoG = new CalculateForNoG();

            double LT2 = Convert.ToDouble(Lt_2.Value);
            double LT3 = Convert.ToDouble(Lt_3.Value);
            double LT4 = Convert.ToDouble(Lt_4.Value);
            double LT5 = Convert.ToDouble(Lt_5.Value);
            double LT6 = Convert.ToDouble(Lt_6.Value);

            double LC12 = Convert.ToDouble(Lc1_2.Value);
            double LC13 = Convert.ToDouble(Lc1_3.Value);
            double LC14 = Convert.ToDouble(Lc1_4.Value);
            double LC15 = Convert.ToDouble(Lc1_5.Value);
            double LC16 = Convert.ToDouble(Lc1_6.Value);

            double LC22 = Convert.ToDouble(Lc2_2.Value);
            double LC23 = Convert.ToDouble(Lc2_3.Value);
            double LC24 = Convert.ToDouble(Lc2_4.Value);
            double LC25 = Convert.ToDouble(Lc2_5.Value);
            double LC26 = Convert.ToDouble(Lc2_6.Value);

            double LSH2 = Convert.ToDouble(Lsh_2.Value);
            double LSH3 = Convert.ToDouble(Lsh_3.Value);
            double LSH4 = Convert.ToDouble(Lsh_4.Value);
            double LSH5 = Convert.ToDouble(Lsh_5.Value);
            double LSH6 = Convert.ToDouble(Lsh_6.Value);

            return GetRacticNoG(calcNoG, LT2, LT3, LT4, LT5, LT6, LC12, LC13, LC14, LC15, LC16, LC22, LC23, LC24, LC25, LC26, LSH2, LSH3, LSH4, LSH5, LSH6);
        }

        private static double GetRacticNoG(CalculateForNoG calcNoG, double LT2, double LT3, double LT4, double LT5, double LT6, double LC12, double LC13, double LC14, double LC15, double LC16, double LC22, double LC23, double LC24, double LC25, double LC26, double LSH2, double LSH3, double LSH4, double LSH5, double LSH6)
        {
            return calcNoG.CalculateFirstNoG(LT2, LT3, LT4, LT5, LT6, LC12, LC13, LC14, LC15, LC16, LC22, LC23, LC24, LC25, LC26, LSH2, LSH3, LSH4, LSH5, LSH6);
        }

        public double FillingDataW()
        {
            Calculate calc = new Calculate();
            double W = calc.CalculateSecond(FillingDataR());
            return W;
        }

        public double FillingDataWNoG()
        {
            CalculateForNoG calcNoG = new CalculateForNoG();
            double W = calcNoG.CalculateSecondNoG(FillingDataRNoG());
            return W;
        }

        public void SetDataToCalculate()
        {
            Ractic.Value = Convert.ToDecimal(FillingDataR());
            calculateDecision.Value = Convert.ToDecimal(FillingDataW());
        }

        public void SetDataToCalculateNoG()
        {
            Ractic.Value = Convert.ToDecimal(FillingDataRNoG());
            calculateDecision.Value = Convert.ToDecimal(FillingDataWNoG());
        }

        private void GosCalcculateThis()
        {
            if (!CheckNumericNull() && checkSaveFile.Checked)
            {
                MessageClass MessageAlert = new MessageClass();
                MessageAlert.ShowMessageAlert();
                StatusMessage("CalculateNotOk");
            }
            else 
            {
                SetDataToCalculate();
                StatusMessage("CalculateOK");
            }
        }

        private void NoGosCalcculateThis()
        {
            if (checkSaveFile.Checked && !CheckNumericNullNoG())
            {
                MessageClass MessageAlert = new MessageClass();
                MessageAlert.ShowMessageAlert();
                StatusMessage("CalculateNotOk");
            }
            else
            {
                SetDataToCalculateNoG();
                StatusMessage("CalculateOK");
            }
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            UpdateValueRandW();

            switch (checkGOS.Checked)
            {
                case true:
                    GosCalcculateThis();
                    break;

                case false:
                    NoGosCalcculateThis();
                    break;
                default:
                    break;
            }
        }


        public bool CheckNumericNull()
        {
            bool Answer = Lt_1.Value == 0.00M || Lt_2.Value == 0.00M || Lt_3.Value == 0.00M || Lt_4.Value == 0.00M || Lt_5.Value == 0.00M || Lt_6.Value == 0.00M || Lt_7.Value == 0.00M || Lc1_1.Value == 0.00M || Lc1_2.Value == 0.00M || Lc1_3.Value == 0.00M || Lc1_4.Value == 0.00M || Lc1_5.Value == 0.00M || Lc1_6.Value == 0.00M || Lc1_7.Value == 0.00M || Lc2_1.Value == 0.00M || Lc2_2.Value == 0.00M || Lc2_3.Value == 0.00M || Lc2_4.Value == 0.00M || Lc2_5.Value == 0.00M || Lc2_6.Value == 0.00M || Lc2_7.Value == 0.00M || Lsh_1.Value == 0.00M || Lsh_2.Value == 0.00M || Lsh_3.Value == 0.00M || Lsh_4.Value == 0.00M || Lsh_5.Value == 0.00M || Lsh_6.Value == 0.00M || Lsh_7.Value == 0.00M
                    ? false
                    : true;
            return Answer;
        }

        public bool CheckNumericNullNoG()
        {
            bool Answer = Lt_2.Value == 0.00M || Lt_3.Value == 0.00M || Lt_4.Value == 0.00M || Lt_5.Value == 0.00M || Lt_6.Value == 0.00M || Lc1_2.Value == 0.00M || Lc1_3.Value == 0.00M || Lc1_4.Value == 0.00M || Lc1_5.Value == 0.00M || Lc1_6.Value == 0.00M || Lc2_2.Value == 0.00M || Lc2_3.Value == 0.00M || Lc2_4.Value == 0.00M || Lc2_5.Value == 0.00M || Lc2_6.Value == 0.00M || Lsh_2.Value == 0.00M || Lsh_3.Value == 0.00M || Lsh_4.Value == 0.00M || Lsh_5.Value == 0.00M || Lsh_6.Value == 0.00M
                ? false
                : true;
            return Answer;
        }
        
        private void SaveInFile_Click(object sender, EventArgs e)
        {
            if (checkGOS.Checked && checkSaveFile.Checked && !CheckNumericNull() || checkSaveFile.Checked && !CheckNumericNullNoG())
            {
                MessageClass MessageAlert = new MessageClass();
                MessageAlert.ShowMessageAlert();
            }
            else
            {
                MessageClass MessageOk = new MessageClass();
                MessageOk.ShowMessageOk();
            }
        }

        private void ChangeLabeOP()
        {
            LabelOP_2.Text = "2";
            LabelOP_3.Text = "3";
            LabelOP_4.Text = "4";
            LabelOP_5.Text = "5";
            LabelOP_6.Text = "6";
        }

        private void ChangeLabeOPNoG()
        {
            LabelOP_2.Text = "1";
            LabelOP_3.Text = "2";
            LabelOP_4.Text = "3";
            LabelOP_5.Text = "4";
            LabelOP_6.Text = "5";
        }

        private void checkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGOS.Checked)
            {
                SetVisibility();
                ChangeLabeOP();
            }
            else
            {
                NoVisibility();
                ChangeLabeOPNoG();
            }

        }
        private void StatusMessage(string status)
        {
            switch (status) 
            {
                case "CalculateOK":
                    StatusCalulate.Text = "Расчет произведен";
                    break;
                case "CalculateNotOk":
                    StatusCalulate.Text = "Ошибка данные неверны!";
                    break;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllValue();
        }

        private decimal ClearModDecimal()
        {
            decimal AnswerDecimal = 0.00M;
            return AnswerDecimal;
        }

        private void ClearAllValue()
        {
            calculateDecision.Value = ClearModDecimal();
            Ractic.Value = ClearModDecimal();
            Lt_1.Value = ClearModDecimal();
            Lt_2.Value = ClearModDecimal();
            Lt_3.Value = ClearModDecimal();
            Lt_4.Value = ClearModDecimal();
            Lt_5.Value = ClearModDecimal();
            Lt_6.Value = ClearModDecimal();
            Lt_7.Value = ClearModDecimal();

            Lc1_1.Value = ClearModDecimal();
            Lc1_2.Value = ClearModDecimal();
            Lc1_3.Value = ClearModDecimal();
            Lc1_4.Value = ClearModDecimal();
            Lc1_5.Value = ClearModDecimal();
            Lc1_6.Value = ClearModDecimal();
            Lc1_7.Value = ClearModDecimal();

            Lc2_1.Value = ClearModDecimal();
            Lc2_2.Value = ClearModDecimal();
            Lc2_3.Value = ClearModDecimal();
            Lc2_4.Value = ClearModDecimal();
            Lc2_5.Value = ClearModDecimal();
            Lc2_6.Value = ClearModDecimal();
            Lc2_7.Value = ClearModDecimal();

            Lsh_1.Value = ClearModDecimal();
            Lsh_2.Value = ClearModDecimal();
            Lsh_3.Value = ClearModDecimal();
            Lsh_4.Value = ClearModDecimal();
            Lsh_5.Value = ClearModDecimal();
            Lsh_6.Value = ClearModDecimal();
            Lsh_7.Value = ClearModDecimal();
        }
        
        private void UpdateValueRandW()
        {
            calculateDecision.Value = ClearModDecimal();
            Ractic.Value = ClearModDecimal();
        }

        private void SetVisibility()
        {
            Lt_1.Visible = checkGOS.Checked;
            Lt_7.Visible = checkGOS.Checked;

            Lc1_1.Visible = checkGOS.Checked;
            Lc1_7.Visible = checkGOS.Checked;

            Lc2_1.Visible = checkGOS.Checked;
            Lc2_7.Visible = checkGOS.Checked;

            Lsh_1.Visible = checkGOS.Checked;
            Lsh_7.Visible = checkGOS.Checked;
            
            LabelOP_1.Visible = checkGOS.Checked;
            LabelOP_7.Visible = checkGOS.Checked;
        }

        private void NoVisibility()
        {
            Lt_1.Visible = false;
            Lt_7.Visible = false;

            Lc1_1.Visible = false;
            Lc1_7.Visible = false;

            Lc2_1.Visible = false;
            Lc2_7.Visible = false;

            Lsh_1.Visible = false;
            Lsh_7.Visible = false;
            
            LabelOP_1.Visible = false;
            LabelOP_7.Visible = false;
        }
        private void CheckSaveFile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RandomGet_Click(object sender, EventArgs e)
        {
            GetRandomValues();
        }
        
        private void GetRandomValues()
        {
            Random GetRandomValues = new Random();
            
            Lt_2.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lt_3.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lt_4.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lt_5.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lt_6.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
           
            Lc1_2.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc1_3.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc1_4.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc1_5.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc1_6.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            
            Lc2_2.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc2_3.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc2_4.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc2_5.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lc2_6.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            
            Lsh_2.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lsh_3.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lsh_4.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lsh_5.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            Lsh_6.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);

            if (checkGOS.Checked)
            {
                Lt_1.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
                Lt_7.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);

                Lc1_1.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
                Lc1_7.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);

                Lc2_1.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
                Lc2_7.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);

                Lsh_1.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
                Lsh_7.Value = Convert.ToDecimal(GetRandomValues.Next(1000) / 10.0);
            }
        }
    }
}
