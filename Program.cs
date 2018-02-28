using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] company = { "台北","台中","高雄"};
            int[,] income= { { 1000, 2000, 3000, 4000 }, 
                             { 1500, 2500, 3500, 4500 }, 
                             { 3200, 1800, 3600, 1400 } };      // 3,4
            int[] sum= {0,0,0 };  // int[] sum=new int[3]    0 1 2

            for (int i = 0; i <= income.GetUpperBound(0); i++)  //0 1 2 有三個  但因為只會傳回2 所以要用<=
            {
                for (int j = 0; j <=income.GetUpperBound(1) ; j++)   //0.1.2.3
                {
                    sum[i] = sum[i] + income[i, j];
                }
            }

            string message = "營業處\t第1季\t第2季\t第3季\t第4季\t合計\n\n";

            for (int i = 0; i <= income.GetUpperBound(0); i++)
            {
                message = message + company[i]+"\t";

                for (int j = 0; j <= income.GetUpperBound(1); j++)
                {
                    message += income[i,j].ToString()+"\t";
                }

                message += sum[i]+"\n";
                        
            }
            MessageBox.Show(message, "營業報表"); //用mesbox做輸出
            Close();
        }
    }
}
