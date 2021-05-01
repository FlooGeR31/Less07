using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less07
{

    // Не ясна работа Stack
    public partial class Form1 : Form
    {
        public static int myCountCommand = 0;
        private Random Rand = new Random();
        private int Task = 0;
        
        


        public Form1()
        {
            
            InitializeComponent();
           
            this.Width = 310;
            Task = Rand.Next(2, 100);
        }
        //Stack<int> st = new Stack<int>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            //st.Push(int.Parse(lblNumber.Text));
            //lblNumber.Text = string.Empty;

            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            myCountCommand++;
            ClickSteps.Text = myCountCommand.ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            //st.Push(int.Parse(lblNumber.Text));
            //lblNumber.Text = string.Empty;

            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            myCountCommand++;
            ClickSteps.Text = myCountCommand.ToString();
        }

       

        private void ButPlay_Click(object sender, EventArgs e)
        {
            panelGame.Left = 0;
            LableNum.Text = Task.ToString();
            LableComand.Text = countCommand(Task).ToString();

        }

        

        private void butMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны что хотите выйти в меню?\n" +
                                            "Все результаты будут сброшены!", "Набери число",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            panelGame.Left = 300;

        }
        private void ButExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int countCommand(int num)
        {
            int temp = num;
            int countCom = 0;
            for (; temp != 1;)
            {
                if (temp % 2 == 0)
                    temp /= 2;
                else temp -= 1;

                countCom++;
            }
            return countCom;
        }



        private void butBack_Click(object sender, EventArgs e)
        {
            //st.Pop();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            myCountCommand = 0;
            ClickSteps.Text = "0";


        }
    }
}
