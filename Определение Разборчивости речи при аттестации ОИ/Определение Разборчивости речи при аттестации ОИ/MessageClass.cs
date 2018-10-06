using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Определение_Разборчивости_речи_при_аттестации_ОИ
{
    class MessageClass
    {
        public void ShowMessageOk()
        {
            MessageBox.Show("Ok!");
        }
        public void ShowMessageAlert()
        {
            MessageBox.Show("Значение не заполнены или заполнены не правильно!");
        }
    }
}
