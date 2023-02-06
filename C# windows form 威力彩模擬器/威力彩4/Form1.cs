using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 威力彩4
{
    public partial class Form1 : Form
    {
        Random myRnd = new Random();
        int[] arraymy = new int[7]; //我的號碼的陣列
        int[] arrayhis = new int[7]; //開獎的陣列
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("請自行選號或電腦選號", "您好", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        private void btn電腦選號_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 6; i++) //6個位元[6]
            {
                arraymy[i] = myRnd.Next(1, 39); //1~38

                for (int j = 0; j < i; j++) 
                {
                    while (arraymy[j] == arraymy[i]) //
                    {
                        j = 0;   //重複=0重新計算
                        arraymy[i] = myRnd.Next(1, 39);
                    }
                }
            }
            txt1.Text = arraymy[0].ToString();
            txt2.Text = arraymy[1].ToString();
            txt3.Text = arraymy[2].ToString();
            txt4.Text = arraymy[3].ToString();
            txt5.Text = arraymy[4].ToString();
            txt6.Text = arraymy[5].ToString();
            arraymy[6] = myRnd.Next(1, 9);
            //txta特別號.Text = ramdomArray1[6].ToString();
            txt特別號.Text = arraymy[6].ToString();
        }

        private void btn開獎_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                arrayhis[i] = myRnd.Next(1, 39);

                for (int j = 0; j < i; j++)
                {
                    while (arrayhis[j] == arrayhis[i])
                    {
                        j = 0;
                        arrayhis[i] = myRnd.Next(1, 39);
                    }
                }
            }
            lbl1.Text = arrayhis[0].ToString();
            lbl2.Text = arrayhis[1].ToString();
            lbl3.Text = arrayhis[2].ToString();
            lbl4.Text = arrayhis[3].ToString();
            lbl5.Text = arrayhis[4].ToString();
            lbl6.Text = arrayhis[5].ToString();
            arrayhis[6] = myRnd.Next(1, 9);
            //txtb特別號.Text = ramdomArray2[6].ToString();
            lbl特別號.Text = arrayhis[6].ToString();
        }

        private void btn開獎結果_Click(object sender, EventArgs e)
        {
            //把字串轉換成int
            arraymy[0] = Convert.ToInt32(txt1.Text);
            arraymy[1] = Convert.ToInt32(txt2.Text);
            arraymy[2] = Convert.ToInt32(txt3.Text);
            arraymy[3] = Convert.ToInt32(txt4.Text);
            arraymy[4] = Convert.ToInt32(txt5.Text);
            arraymy[5] = Convert.ToInt32(txt6.Text);
            arraymy[6] = Convert.ToInt32(txt特別號.Text);

            // 
            int count = 0; 
            int count2 = 0;
            for (int i=0; i<6; i++)
            {
                for (int j=0; j<6; j++)
                {
                    if (arraymy[i] == arrayhis[j])
                    {
                        count++; //一個一樣就會加一個count
                    }
                }
            }
           if (arraymy[6] == arrayhis[6]) //特別號
            {
                count2 = 1;
            }
           if(count == 6 && count2 == 1)
            {
                //1
                lbl開獎資訊.Text = ("恭喜中獎!!頭獎 NT$100,000,000");
            }
            if (count == 6 && count2 != 1)
            {
                //2
                lbl開獎資訊.Text = ("恭喜中獎!!貳獎 NT$5,000,000");
            }
            if (count == 5 && count2 == 1)
            {
                //3
                lbl開獎資訊.Text = ("恭喜中獎!!參獎 NT$150,000");

            }
            if (count == 5 && count2 != 1)
            {
                //4
                lbl開獎資訊.Text = ("恭喜中獎!!肆獎 NT$20,000");
            }
            if (count == 4 && count2 == 1)
            {
                //5
                lbl開獎資訊.Text = ("恭喜中獎!!伍獎 NT$4,000");
            }
            if (count == 4 && count2 != 1)
            {
                //6
                lbl開獎資訊.Text = ("恭喜中獎!!陸獎 NT$800");
            }
            if (count == 3 && count2 == 1)
            {
                //7
                lbl開獎資訊.Text = ("恭喜中獎!!柒獎 NT$400");
            }
            if (count == 2 && count2 == 1)
            {
                //8
                lbl開獎資訊.Text = ("恭喜中獎!!捌獎 NT$200");
            }
            if (count == 3 && count2 != 1)
            {
                //9
                lbl開獎資訊.Text = ("恭喜中獎!!玖獎 NT$100");
            }
            if (count == 1 && count2 == 1)
            {
                //10
                lbl開獎資訊.Text = ("恭喜中獎!!普獎 NT$100");
            }
            if (count == 2 && count2 == 0) 
            {
                //11
                lbl開獎資訊.Text = ("差點中獎QQ 歡迎再來");
            }
            if (count == 0 && count2 == 0)
            {
                //12
                lbl開獎資訊.Text = ("差點中獎QQ 歡迎再來");
            }
            if (count == 1 && count2 == 0)
            {
                //13
                lbl開獎資訊.Text = ("差點中獎QQ 歡迎再來");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn包牌_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            
            myForm2.ShowDialog();
        }

        private void btn隨機十組_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();

            myForm3.ShowDialog();
        }
    }
}
