using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Events
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            Random rnd = new Random();
            int value = 0;
            int attempt = 0;
            while (value!=number)
            {
                attempt++;
                value= rnd.Next(1,2001);
                if(value == number)
                {
                    MessageBox.Show($"Ваше число {number} було відгадано за {attempt} спроб");
                }
            }
        }
    }
}
