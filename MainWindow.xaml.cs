using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeightCalculate
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        double douOutput;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void calculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtMg.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtKg.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtT.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtOz.Text = string.Format("{0:0.##########}", _value / 28349);
            if (_kind != 5)
                txtLb.Text = string.Format("{0:0.##########}", _value / 453592);
        }
        private void txtMg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMg.Text = "";
            }
        }

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtG.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(1, douOutput * 1000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtG.Text = "";
            }
        }

        private void txtKg_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput = txtKg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKg.Text = "";
            }
        }
        private void txtT_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput = txtT.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(3, douOutput * 1000000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtT.Text = "";
            }
        }

        private void txtOz_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput = txtOz.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(4, douOutput * 28349);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOz.Text = "";
            }
        }
        private void txtLb_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput = txtLb.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                calculateAnswer(5, douOutput * 453592);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtLb.Text = "";
            }
        }
        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMg.Text = "";
            txtG.Text = "";
            txtKg.Text = "";
            txtT.Text = "";
            txtOz.Text = "";
            txtLb.Text = "";
        }
    }
}
