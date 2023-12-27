using System;

namespace moi
{
    class Viikonpaivat
    {
        public void MikaPaiva(string userInput)
        {
            try
            {
                int paiva = Convert.ToInt32(userInput);
                if (paiva < 1 || paiva > 7)
                {
                    MessageBox.Show("Invalid day. Please enter an integer between 1 and 7.");
                    return;
                }
                switch (paiva)
                {
                    case 1:
                        MessageBox.Show("Maanantai");
                        break;
                    case 2:
                        MessageBox.Show("Tiistai");
                        break;
                    case 3:
                        MessageBox.Show("Keskiviikko");
                        break;
                    case 4:
                        MessageBox.Show("Torstai");
                        break;
                    case 5:
                        MessageBox.Show("Perjantai");
                        break;
                    case 6:
                        MessageBox.Show("Lauantai");
                        break;
                    case 7:
                        MessageBox.Show("Sunnuntai");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter an integer between 1 and 7.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        private Button button1;
        private TextBox textBox1;

        public Form1()
        {
            button1 = new Button();
            textBox1 = new TextBox();

            button1.Text = "Submit";
            button1.Dock = DockStyle.Bottom;
            button1.Click += new EventHandler(button1_Click);

            textBox1.Dock = DockStyle.Top;

            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Anna viikonpaiva numeroina";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viikonpaivat vp = new Viikonpaivat();
            vp.MikaPaiva(textBox1.Text);

        }
    }
}
