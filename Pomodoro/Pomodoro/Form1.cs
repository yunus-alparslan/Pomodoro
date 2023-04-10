using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0,dakika=60,saniye=60;
  
        private void button1_Click(object sender, EventArgs e)
        {
            saat = Convert.ToInt16(textBox1.Text);
            label4.Text = saat.ToString();
            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            saniye--;

            label2.Text = saniye.ToString();


                if (dakika == 59)
                {

                    pictureBox1.Visible = true;
                  //  pictureBox2.Visible = true;
                }
                else if (dakika == 57)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                }
                else if (saat ==0 & dakika == 30)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                }
                else if(saat ==0 & dakika == 20)
                {
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                }
                else if (saat ==0 & dakika == 2)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                }
  
            if (saniye==-1)
            {
                dakika--;
                saniye = 60;
              

                label3.Text = dakika.ToString();
                if (dakika == -1)
                {
                    dakika = 60;
                    saat--;
                    label4.Text = saat.ToString();
                }

            }
            if (saat == 0 & saniye == 0 & dakika == 0)
            {
                timer1.Stop();
                MessageBox.Show("Görev Tamamlanmıştır");
            }




        }



    }
}
