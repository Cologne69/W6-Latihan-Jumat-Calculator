using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W6__Latihan_Jumat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;


        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_satu_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "1";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "1";
            }
                
        }

        private void btn_dua_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "2";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "2";
            }
        }

        private void btn_tiga_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "3";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "3";
            }
        }

        private void btn_empat_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "4";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "4";
            }
        }

        private void btn_lima_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "5";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "5";
            }
        }

        private void btn_enam_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "6";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "6";
            }
        }

        private void btn_tujuh_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "7";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "7";
            }
        }

        private void btn_delapan_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "8";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "8";
            }
        }

        private void btn_sembilan_Click(object sender, EventArgs e)
        {
            if (txtboxinput.Text == "0" && txtboxinput.Text != null)
            {
                txtboxinput.Text = "9";
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text + "9";
            }
        }

        private void btn_nol_Click(object sender, EventArgs e)
        {
            
            
              txtboxinput.Text = txtboxinput.Text + "0";
            
        }
        double firstnumber;
        string operation;
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtboxinput.Text);
            txtboxinput.Text = "0";
            operation = "+";
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double secondnumber;
            double result;

            secondnumber = Convert.ToDouble(txtboxinput.Text);
           

            if (operation == "+")
            {
                result = firstnumber + secondnumber;
                txtboxinput.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "-")
            {
                result = firstnumber - secondnumber;
                txtboxinput.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "*")
            {
                result = firstnumber * secondnumber;
                txtboxinput.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "/")
            {
                result = firstnumber / secondnumber;
                txtboxinput.Text = Convert.ToString(result);
                firstnumber = result;
            }
            lbox_history.Items.Add(txtboxinput.Text);
            counter += 1;
            txtboxinput.Text = "0";
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtboxinput.Text);
            txtboxinput.Text = "0";
            operation = "-";
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtboxinput.Text);
            txtboxinput.Text = "0";
            operation = "*";
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtboxinput.Text);
            txtboxinput.Text = "0";
            operation = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxinput.Text = "0";
            this.KeyPreview = true;
            
                
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtboxinput.Text="0";

        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            
            if ((String.Compare(txtboxinput.Text, " ") < 0))
            {
                txtboxinput.Text = txtboxinput.Text.Substring(0, txtboxinput.Text.Length - 1 + 1);
            }
            else
            {
                txtboxinput.Text = txtboxinput.Text.Substring(0, txtboxinput.Text.Length - 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                btn_backspace.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn_satu.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn_dua.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3 )
            {
                btn_tiga.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn_empat.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn_lima.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn_enam.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn_tujuh.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8 )
            {
                btn_delapan.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn_sembilan.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn_nol.PerformClick();

            }
        }

        private void btn_satu_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            if (lbox_history.SelectedIndex == counter)
            {
                lbox_history.SelectedIndex -= 2;
                MessageBox.Show("Data sudah max");
            }
            else 
            {
                lbox_history.SelectedIndex += 1;
            }
        }

        private void btn_mundur_Click(object sender, EventArgs e)
        {
            if(lbox_history.SelectedIndex < 0)
            {
                lbox_history.SelectedIndex = 0;
            }
            if (lbox_history.SelectedIndex > 0)
            {
                lbox_history.SelectedIndex = -1;
            }
        }
    }
}
