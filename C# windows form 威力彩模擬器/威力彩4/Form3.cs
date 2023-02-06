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
    public partial class Form3 : Form
    {
        Random myRnd = new Random();
        int[] arraymy = new int[7];
        int[,] array2 = new int[10, 7];
        public Label myDynamicLabel;
        public List<Button> listDbutton = new List<Button>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            動態程式語法產生Label();
            動態產生按鈕(10, 7);

            listDbutton[6 ].BackColor = Color.Yellow;
            listDbutton[13].BackColor = Color.Yellow;
            listDbutton[20].BackColor = Color.Yellow;
            listDbutton[27].BackColor = Color.Yellow;
            listDbutton[34].BackColor = Color.Yellow;
            listDbutton[41].BackColor = Color.Yellow;
            listDbutton[48].BackColor = Color.Yellow;
            listDbutton[55].BackColor = Color.Yellow;
            listDbutton[62].BackColor = Color.Yellow;
            listDbutton[69].BackColor = Color.Yellow;
            listDbutton[6 ].ForeColor = Color.Red;
            listDbutton[13].ForeColor = Color.Red;
            listDbutton[20].ForeColor = Color.Red;
            listDbutton[27].ForeColor = Color.Red;
            listDbutton[34].ForeColor = Color.Red;
            listDbutton[41].ForeColor = Color.Red;
            listDbutton[48].ForeColor = Color.Red;
            listDbutton[55].ForeColor = Color.Red;
            listDbutton[62].ForeColor = Color.Red;
            listDbutton[69].ForeColor = Color.Red;
        }
        void 動態程式語法產生Label()
        {
            myDynamicLabel = new Label();
            myDynamicLabel.BackColor = Color.Red;
            myDynamicLabel.ForeColor = Color.Yellow;
            myDynamicLabel.Font = new Font("微軟正黑體", 18);
            myDynamicLabel.Name = "lblDyLabelOne";
            myDynamicLabel.Text = "隨機十組號碼";
            myDynamicLabel.TextAlign = ContentAlignment.TopCenter;
            myDynamicLabel.Location =new Point(50, 10);
            myDynamicLabel.Size = new Size(400, 34);

            Controls.Add(myDynamicLabel);
        }
        private void dButton_Click(object sender, EventArgs e)
        {
           
        }
        void 動態產生按鈕(int intRow, int intColumn)
        {

            int serrialNo = 0;
            int m1 = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    arraymy[i] = myRnd.Next(1, 39);

                    for (int j = 0; j < i; j++)
                    {
                        while (arraymy[j] == arraymy[i])
                        {
                            j = 0;
                            arraymy[i] = myRnd.Next(1, 39);
                        }
                    }
                    array2[m1, i] = arraymy[i];
                }
                arraymy[6] = myRnd.Next(1, 9);
                array2[m1, 6] = arraymy[6];
                m1++;
            }
            for (int i1 = 0; i1 < intRow; i1++)
            {
                for (int j1 = 0; j1 < intColumn; j1++)
                {
                    serrialNo = array2[i1, j1];
                    Button dbutton = new Button();
                    dbutton.BackColor = Color.White;
                    dbutton.ForeColor = Color.Blue;
                    dbutton.Font = new Font("微軟正黑體", 18);
                    dbutton.Text = serrialNo.ToString();
                    dbutton.Name = serrialNo.ToString();
                    dbutton.Location = new Point(25 + 68 * j1, 60 + 42 * i1);
                    dbutton.Size = new Size(66, 40);
                    dbutton.Click += new EventHandler(dButton_Click);
                    Controls.Add(dbutton);
                    listDbutton.Add(dbutton);
                }
            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
