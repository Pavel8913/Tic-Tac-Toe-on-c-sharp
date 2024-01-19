using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool metka = false;
        int cl = 1;
        int нолики=0, крестики=0;
        private void bt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            reset();
        }
        
        private void reset()
        {
            cl = 1;
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }
     
        #region проверка
        private void proverka()
        {
            //Первая горизонталь
            if (bt1.Text == "0" && bt2.Text == "0" && bt3.Text == "0")
            {
                MessageBox.Show("Победили нолики!");
                reset();
                нолики++;
                label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                

            }
            if (bt1.Text == "Х" && bt2.Text == "Х" && bt3.Text == "Х")
            {
                MessageBox.Show("Победили крестики!");
                reset();
                крестики++;
                label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                
            }
            //вторая горизонталь
            if (bt4.Text == "0" && bt5.Text == "0" && bt6.Text == "0")
            {
                MessageBox.Show("Победили нолики!");
                reset();
                нолики++;
                label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;

            }
            if (bt4.Text == "Х" && bt5.Text == "Х" && bt6.Text == "Х")
            {
                MessageBox.Show("Победили крестики!");
                reset();
                крестики++;
                label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
            }
            //Третья горизонталь
            if (bt7.Text == "0" && bt8.Text == "0" && bt9.Text == "0")
            {
                MessageBox.Show("Победили нолики!");
                reset();
                нолики++;
                label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
            }
            if (bt7.Text == "Х" && bt8.Text == "Х" && bt9.Text == "Х")
            {
                MessageBox.Show("Победили крестики!");
                reset();
                крестики++;
                label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
            }
            //Первый крест
            if (bt1.Text == "0" && bt5.Text == "0" && bt9.Text == "0")
            {
                MessageBox.Show("Победили нолики!");
                reset();
                нолики++;
                label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;

            }
            if (bt1.Text == "Х" && bt5.Text == "Х" && bt9.Text == "Х")
            {
                MessageBox.Show("Победили крестики!");
                reset();
                крестики++;
                label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
            }
            //Второй крест
                if (bt3.Text == "0" && bt5.Text == "0" && bt6.Text == "0")
                {
                    MessageBox.Show("Победили нолики!");
                    reset();
                    нолики++;
                    label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
                if (bt3.Text == "Х" && bt5.Text == "Х" && bt6.Text == "Х")
                {
                    MessageBox.Show("Победили крестики!");
                    reset();
                    крестики++;
                    label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                }
                if (bt1.Text == "0" && bt4.Text == "0" && bt7.Text == "0")
                {
                    MessageBox.Show("Победили нолики!");
                    reset();
                    нолики++;
                    label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
                if (bt1.Text == "Х" && bt4.Text == "Х" && bt7.Text == "Х")
                {
                    MessageBox.Show("Победили крестики!");
                    reset();
                    крестики++;
                    label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                }
                if (bt1.Text == "0" && bt4.Text == "0" && bt7.Text == "0")
                {
                    MessageBox.Show("Победили нолики!");
                    reset();
                    нолики++;
                    label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
                if (bt2.Text == "Х" && bt5.Text == "Х" && bt8.Text == "Х")
                {
                    MessageBox.Show("Победили крестики!");
                    reset();
                    крестики++;
                    label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                }
                if (bt2.Text == "0" && bt5.Text == "0" && bt8.Text == "0")
                {
                    MessageBox.Show("Победили нолики!");
                    reset();
                    нолики++;
                    label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
                if (bt3.Text == "Х" && bt6.Text == "Х" && bt9.Text == "Х")
                {
                    MessageBox.Show("Победили крестики!");
                    reset();
                    крестики++;
                    label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                }
                if (bt3.Text == "0" && bt6.Text == "0" && bt9.Text == "0")
                {
                    MessageBox.Show("Победили нолики!");
                    reset();
                    нолики++;
                    label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
                if (bt7.Text == "Х" && bt5.Text == "Х" && bt3.Text == "Х")
                {
                    MessageBox.Show("Победили крестики!");
                    reset();
                    крестики++;
                    label1.Text = "Победили \r\nкрестики\r\n(раз):" + крестики;
                }
                if(bt7.Text == "0" && bt5.Text == "0" && bt3.Text == "0")
                {
                MessageBox.Show("Победили нолики!");
                reset();
                нолики++;
                label2.Text = "Победили \r\nнолики\r\n(раз):" + нолики;
                }
            #endregion
        #region кнопки
        }
        private void bt1_Click(object sender, EventArgs e)
        {                      
            if(cl%2==0)
            {
                bt1.Text = "0";
                //bt2.ForeColor= Color.White;
            }
            else
            {
                bt1.Text = "Х"; 
                //bt1.BackColor=Color.Transparent;
                //bt1.FlatStyle = FlatStyle.Popup;
                //bt1.ForeColor = Color.Black;
               
            }
            cl++;
            bt1.Enabled = false;
            proverka();
           
        }
       
        private void bt2_Click(object sender, EventArgs e)
        {            
            if (cl % 2 == 0)
            {
                bt2.Text = "0";
            }
            else
            {
                bt2.Text = "Х";
            }
            cl++;
            bt2.Enabled = false;
            proverka();
        }

       
        private void bt7_Click(object sender, EventArgs e)
        {

            if (cl % 2 == 0)
            {
                bt7.Text = "0";
            }
            else
            {
                bt7.Text = "Х";
            }
            cl++;
            bt7.Enabled = false;
            proverka();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt3.Text = "0";
            }
            else
            {
                bt3.Text = "Х";
            }
            cl++;
            bt3.Enabled = false;
            proverka();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt4.Text = "0";
            }
            else
            {
                bt4.Text = "Х";
            }
            cl++;
            bt4.Enabled = false;
            proverka();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt5.Text = "0";
            }
            else
            {
                bt5.Text = "Х";
            }
            cl++;
            bt5.Enabled = false;
            proverka();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt6.Text = "0";
            }
            else
            {
                bt6.Text = "Х";
            }
            cl++;
            bt6.Enabled = false;
            proverka();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt8.Text = "0";
            }
            else
            {
                bt8.Text = "Х";
            }
            cl++;
            bt8.Enabled = false;
            proverka();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (cl % 2 == 0)
            {
                bt9.Text = "0";
            }
            else
            {
                bt9.Text = "Х";
            }
            cl++;
            bt9.Enabled = false;
            proverka();

        }
        #endregion


    }
}
