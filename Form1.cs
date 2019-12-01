using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int picking_number;
        public float font_size;

        int[] check_Category = new int[4] { 0,0,0,0 };
        int[] selected_Number = new int[10];
        int[] selected_Number1 = new int[10];
        int[] selected_Number2 = new int[10];
        int[] selected_Number3 = new int[10];
        int[] selected_Number4 = new int[10];
        bool chBox1_changed = true;
        bool chBox2_changed = true;
        bool chBox3_changed = true;
        bool chBox4_changed = true;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox1_changed)
            {
                check_Category[0] = 3;
                chBox1_changed = false;
            }
            else
            {
                check_Category[0] = 0;
                chBox1_changed = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox2_changed)
            {
                check_Category[1] = 2;
                chBox2_changed = false;
            }
            else
            {
                check_Category[1] = 0;
                chBox2_changed = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox3_changed)
            {
                check_Category[2] = 1;
                chBox3_changed = false;
            }
            else
            {
                check_Category[2] = 0;
                chBox3_changed = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox4_changed)
            {
                check_Category[3] = 4;
                chBox4_changed = false;
            }
            else
            {
                check_Category[3] = 0;
                chBox4_changed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.picking_number = Convert.ToInt32(this.word_Number.Text);
            this.font_size = (float)Convert.ToDouble(this.FontSize.Text);
            if((picking_number <= 40) && (picking_number >= 0))
            {
                DisaplyWords display = new DisaplyWords(ref check_Category, picking_number, font_size);
                display.Displaying_Words();
                display.ShowDialog();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
