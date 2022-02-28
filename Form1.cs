using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkCalc;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {



            string adresa = IPadresa.Text;
            if (adresa != "")
            {

                label2.Visible = true;
                string prefix = prefix0.Text;
                IPAdress adr1 = new IPAdress(adresa);
                adr1.Prefix = new Prefix(prefix);
                adr1.SubnetMask = new SubnetMask(Convert.ToString(adr1.Prefix));
                int? hosts = null;
                hosts = int.Parse(textBoxHost.Text);
                adr1.Pocitej(hosts, radioButtonAno1.Checked);
                int i = 1;
                int pre = 0;

                    foreach (IPAdress c in adr1.RangeAz)
                    {
                    UserControl uCRange = new UserControl();
                    uCRange.Size = new System.Drawing.Size(240, 15);
                    uCRange.Controls.Add(new Label() { Location = new System.Drawing.Point(0, 0), Size = new System.Drawing.Size(32, 13), Text = Convert.ToString(i) + ")" });
                    uCRange.Controls.Add(new TextBox() { BorderStyle = System.Windows.Forms.BorderStyle.None, ReadOnly = true, Size = new System.Drawing.Size(88, 13), Location = new System.Drawing.Point(37, 0), Text = Convert.ToString(adr1.Range[pre]) });
                    uCRange.Controls.Add(new Label() { Location = new System.Drawing.Point(131, 0), Size = new System.Drawing.Size(10, 13), Text = "-" });
                    uCRange.Controls.Add(new TextBox() { BorderStyle = System.Windows.Forms.BorderStyle.None, ReadOnly = true, Size = new System.Drawing.Size(88, 13), Location = new System.Drawing.Point(147, 0), Text = Convert.ToString(c) });
                    i++;
                    pre++;
                    //UserControl1 UC = new UserControl1();
                    //UC.lblIP.Text = c.ToString();

                        flowLayoutPanel1.Controls.Add(uCRange);
                }
                

                textBox1.Text = Convert.ToString(adr1.Prefix);
                textBox2.Text = Convert.ToString(adr1.NetType);
                textBox3.Text = Convert.ToString(adr1.NetworkAdress);
                textBox4.Text = Convert.ToString(adr1.PocetHostu);
                textBox5.Text = Convert.ToString(adr1.broadcast);
                textBox6.Text = Convert.ToString(adr1.PrvniPouzitelna);
                textBox7.Text = Convert.ToString(adr1.NetworkAdress);
            }

            else
            {
                MessageBox.Show("Zadej IP adresu");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            IPadresa.Clear();
            prefix0.Clear();

        }

        private void prefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBoxHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAno_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAno.Checked == true)
            {
                textBoxHost.Visible = true;
                labelKolik.Visible = true;
                labelRange.Visible = true;
                radioButtonAno1.Visible = true;
                radioButtonNe1.Visible = true;
            }
            else
            {
                textBoxHost.Visible = false;
                labelKolik.Visible = false;
                labelRange.Visible = false;
                radioButtonAno1.Visible = false;
                radioButtonNe1.Visible = false;
            }
        }

        private void radioButtonNe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAno1_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void radioButtonNe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonNe1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButtonAno1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        public void userControl11_Load(object sender, EventArgs e)
        {


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
