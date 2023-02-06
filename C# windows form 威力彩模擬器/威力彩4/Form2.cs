using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 威力彩4
{
    public partial class Form2 : Form
    {
        Random myRnd = new Random();
        int[] arraymy = new int[7];
        int[,] array2 = new int[10000,7];
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arraymy[0] = Convert.ToInt32(txt自選號1.Text);
            arraymy[1] = Convert.ToInt32(txt自選號2.Text);
            arraymy[2] = Convert.ToInt32(txt自選號3.Text);
            arraymy[3] = Convert.ToInt32(txt自選號4.Text);
            string aa = "";
            int m1 = 0;
            

            for (int i = 1; i < 39; i++)
            {
                arraymy[4] = i;
                if (arraymy[4] != arraymy[0] && arraymy[4] != arraymy[1] && arraymy[4] != arraymy[2] && arraymy[4] != arraymy[3])
                {
                    for (int j = 1; j<39;j++)

                    {
                        arraymy[5] = j;
                        if (arraymy[5] != arraymy[0] && arraymy[5] != arraymy[1] && arraymy[5] != arraymy[2] && arraymy[5] != arraymy[3] && arraymy[5] != arraymy[4])
                        {
                            for (int k = 1; k < 9; k++)
                            {
                                arraymy[6] = k;
                                array2[m1, 0] = arraymy[0];
                                array2[m1, 1] = arraymy[1];
                                array2[m1, 2] = arraymy[2];
                                array2[m1, 3] = arraymy[3];
                                array2[m1, 4] = arraymy[4];
                                array2[m1, 5] = arraymy[5];
                                array2[m1, 6] = arraymy[6];
                                m1++;
                                string a1 = arraymy[0].ToString();
                                string a2 = arraymy[1].ToString();
                                string a3 = arraymy[2].ToString();
                                string a4 = arraymy[3].ToString();
                                string a5 = arraymy[4].ToString();
                                string a6 = arraymy[5].ToString();
                                string a7 = arraymy[6].ToString();
                                aa =  aa + a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + "  特別號" + a7;
                                aa += "\r\n";
                            }
                           
                        }
                    }
                    txt包牌號碼.Text = aa ;
                }
            }
        }
    }
}
