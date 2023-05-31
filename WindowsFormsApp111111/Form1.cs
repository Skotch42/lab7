using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp111111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int sanctions, quality, price, prob_people, fix_people, brake_diff, popular, count;
        bool is_sanctions;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (is_sanctions)
            {
                is_sanctions = false;
            }
            else
            {
                is_sanctions = true;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            count = 0;

            sanctions = (int)SanctionsValue.Value;
            brake_diff = (int)DifficultyValue.Value;
            quality = QualityValue.Value;
            popular = PopularValue.Value;

            prob_people = random.Next(500, 1000);
            fix_people = random.Next(100, prob_people / 2);
            prob_people = prob_people - random.Next(1, fix_people / 3);
            price = random.Next(5, 100) + popular * 20;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            chart1.Series[0].Points.AddXY(count, prob_people);
            chart1.Series[1].Points.AddXY(count, fix_people);
            chart1.Series[2].Points.AddXY(count, price);

            if (SanctionsPresent.Checked)
            {
                is_sanctions = true;
            }
            else
            {
                is_sanctions = false;
            }

            if (!timer1.Enabled)
            {
                timer1.Start();
                btStart.Text = "Стоп";
            }
            else
            {
                timer1.Stop();
                btStart.Text = "Рестарт";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            sanctions = (int)SanctionsValue.Value;
            brake_diff = (int)DifficultyValue.Value;
            quality = QualityValue.Value;
            popular = PopularValue.Value;

            prob_people = random.Next(500, 1000);
            fix_people = random.Next(100, prob_people / 3);
            prob_people = prob_people - random.Next(1, fix_people / 3);
            price = random.Next(5, 100) + (brake_diff * 35) + popular * 20;

            if (is_sanctions == true)
            {
                price = price + random.Next(1, sanctions * 100);
                fix_people += quality * 55 - price - sanctions * 10 - random.Next(0, (brake_diff + sanctions) / 5) + popular * 35;
            }
            else
            {
                fix_people += quality * 55 - price - random.Next(0, (brake_diff) / 5) + popular * 35;

            }

            if (fix_people < 0)
            {
                lbFixPeople.Text = "0";
                chart1.Series[1].Points.AddXY(count, 0);
            }
            else
            {
                lbFixPeople.Text = fix_people.ToString();
                chart1.Series[1].Points.AddXY(count, fix_people);
            }

            lbProbPeople.Text = prob_people.ToString();
            lbPrice.Text = price.ToString();

            chart1.Series[0].Points.AddXY(count, prob_people);
            chart1.Series[2].Points.AddXY(count, price);

            if (SanctionsPresent.Checked)
            {
                is_sanctions = true;
            }
            else
            {
                is_sanctions = false;
            }

        }

    }
}
