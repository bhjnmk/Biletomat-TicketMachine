using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletomat
{
    
    public partial class Jedn_G : UserControl
    {
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        //Konstruktor                                             
        public Jedn_G()
        {
            InitializeComponent();
            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        //obsluga jezyka
        public void OnEventL(Form frm)
        {
            if (EventLanguage != null)
                EventLanguage(frm, new EventArgs());
        }

        private void EventMethodL(object sender, EventArgs e)
        {
            textBoxL.Text = "E";
            label3.Text = "Single tickets ZKM Gdynia";
            label10.Text = "Single fares\nvalid on standard\nbus line";
            label2.Text = "Single fares\nvalid on night, rapid, special\nand standard bus line";
            label20.Text = "1 hour ticket\nvalid on standard\nbus lines";
            label1.Text = "1 hour ticket\nvalid on night, rapid, special\nand standard bus line";
            label30.Text = "24 hour ticket\nvalid on night, rapid, special\nand standard bus lines";
            label40.Text = "Amount to pay:";
            label11.Text = "Full price 3.20 zl";
            label12.Text = "Reduced 1.60 zl";
            label13.Text = "Full price 4.20 zl";
            label14.Text = "Reduced 2.10 zl";
            label21.Text = "Full price 3.80 zl";
            label22.Text = "Reduced 1.90 zl";
            label23.Text = "Full price 4.80 zl";
            label24.Text = "Reduced 2.40 zl";
            label31.Text = "Full price 13.00 zl";
            label32.Text = "Reduced 6.50 zl";
            buttonZ.Text = "Pay";
            buttonInne.Text = "Other types of tickets";
        }

        public void OnEventJ(Form frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            textBoxL.Text = "P";
            label3.Text = "Bilety jednorazowe ZKM w Gdyni";
            label10.Text = "Jednoprzejazdowy\nna linie zwykłe";
            label2.Text = "Jednoprzejazdowy\nna linie nocne, pospieszne,\nspecjalne i zwykłe";
            label20.Text = "Godzinny\nna linie zwykłe";
            label1.Text = "Godzinny\nna linie nocne, pospieszne,\nspecjalne i zwykłe";
            label30.Text = "24-godzinny\nna linie nocne, pospieszne,\nspecjalne i zwykłe";
            label40.Text = "Do zapłaty:";
            label11.Text = "Normalny 3,20 zł";
            label12.Text = "Ulgowy 1,60 zł";
            label13.Text = "Normalny 4,20 zł";
            label14.Text = "Ulgowy 2,10 zł";
            label21.Text = "Normalny 3,80 zł";
            label22.Text = "Ulgowy 1,90 zł";
            label23.Text = "Normalny 4,80 zł";
            label24.Text = "Ulgowy 2,40 zł";
            label31.Text = "Normalny 13,00 zł";
            label32.Text = "Ulgowy 6,50 zł";
            buttonZ.Text = "Zapłać";
            buttonInne.Text = "Pozostałe rodzaje biletów";
        }

        //Ustawienie wielkości okna i rozmieszczenie
        private void Jedn_G_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 640);
            panel1.Location = new Point(0, 3);
            panel2.Location = new Point(0, 94);
            buttonBack.Visible = false;
            
        }

        //Przekazanie informacji do Platnosci
        public event EventHandler BiletGEvent;

        public double[] BiletGValue
        { 
            get
            {
                double price = SetToPay();
                double which = 1; //jednorazowe
                double[] tickets = new double[12] { which, Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text), price };
                return tickets;                                                                                 
            }
        }

        //Obsluga przycisku Zaplac
        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (textBox40.Text == "0 zł" || textBox40.Text == "" || textBox40.Text == "0 zl")
            {
                if (textBoxL.Text == "E")
                {
                    MessageBox.Show("You must choose at least one ticket.");
                }
                else
                {
                    MessageBox.Show("Wybierz przynajmniej jeden bilet.");
                }
            }
            else
            {
                //Przejscie do platnosci
                Platnosc nowy_pl = new Platnosc();   
                nowy_pl.BringToFront();
                this.SendToBack();

                if (BiletGEvent != null)
                {
                    BiletGEvent(null, null);
                }
                MainForm.OnEventJ(true);
            }
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Obliczanie kwoty do zapłaty
        private double SetToPay()
        {
            double end_price = 0;
            double[] price = new double[10] { 3.2, 1.6, 4.2, 2.1, 3.8, 1.9, 4.8, 2.4, 13, 6.5 };
            int[] tickets = new int[10] { Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text) };

            for (int i = 0; i < 10; i++)
            {
                end_price = end_price + tickets[i] * price[i];
            }

            if (end_price == 0)
            {
                if (textBoxL.Text == "E")
                {
                    textBox40.Text = "0 zl";
                }
                else
                {
                    textBox40.Text = "0 zl";
                }
            }
            else
            {
                if (textBoxL.Text == "E")
                {
                    textBox40.Text = end_price.ToString("#,0.00") + " zl";
                }
                else
                {
                    textBox40.Text = end_price.ToString("#,0.00") + " zł";
                }
                
            }
            return end_price;
        }


        //Metoda +
        private void PlusMethod(int i)
        {
            TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            int t = Convert.ToInt16(tbs[i-1].Text);
            if (t == 99)
            {
                t = 99;
            }
            else
            {
                t = t + 1;
            }
            tbs[i - 1].Text = t.ToString();
            
            SetToPay();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Metoda -
        private void MinusMethod(int i)
        {
            TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 }; 
            int t = Convert.ToInt32(tbs[i-1].Text);
            if (t == 0)
            {
                t = 0;
                tbs[i-1].Text = t.ToString();
            }
            else
            {
                t = t - 1;
                tbs[i-1].Text = t.ToString();
            }
            SetToPay();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Obsluga przyciskow + i -
        private void buttonP1_Click(object sender, EventArgs e)
        {
            PlusMethod(1);
        }

        private void buttonM1_Click(object sender, EventArgs e)
        {
            MinusMethod(1);
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            PlusMethod(2);
        }

        private void buttonM2_Click(object sender, EventArgs e)
        {
            MinusMethod(2);
        }

        private void buttonP3_Click(object sender, EventArgs e)
        {
            PlusMethod(3);
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            MinusMethod(3);
        }

        private void buttonP4_Click(object sender, EventArgs e)
        {
            PlusMethod(4);
        }

        private void buttonM4_Click(object sender, EventArgs e)
        {
            MinusMethod(4);
        }

        private void buttonP5_Click(object sender, EventArgs e)
        {
            PlusMethod(5);
        }

        private void buttonM5_Click(object sender, EventArgs e)
        {
            MinusMethod(5);
        }

        private void buttonP6_Click(object sender, EventArgs e)
        {
            PlusMethod(6);
        }

        private void buttonM6_Click(object sender, EventArgs e)
        {
            MinusMethod(6);
        }

        private void buttonP7_Click(object sender, EventArgs e)
        {
            PlusMethod(7);
        }

        private void buttonM7_Click(object sender, EventArgs e)
        {
            MinusMethod(7);
        }

        private void buttonP8_Click(object sender, EventArgs e)
        {
            PlusMethod(8);
        }

        private void buttonM8_Click(object sender, EventArgs e)
        {
            MinusMethod(8);
        }

        private void buttonP9_Click(object sender, EventArgs e)
        {
            PlusMethod(9);
        }

        private void buttonM9_Click(object sender, EventArgs e)
        {
            MinusMethod(9);
        }

        private void buttonP10_Click(object sender, EventArgs e)
        {
            PlusMethod(10);
        }

        private void buttonM10_Click(object sender, EventArgs e)
        {
            MinusMethod(10);
        }


        //Zerowanie, gdy Home
        private void Jedn_G_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox40.Text = "";
            panel2.SendToBack();
            buttonInne.Visible = true;
            buttonBack.Visible = false;
        }

        //Przycisk Pozostałe
        private void buttonInne_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            buttonInne.Visible = false;
            buttonBack.Visible = true;
            buttonBack.BringToFront();
            MainForm.OnEventBB(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Powrót z pozostałych
        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.BringToFront();
            buttonBack.Visible = false;
            buttonInne.Visible = true;
            MainForm.OnEventBB2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void Jedn_G_LocationChanged(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel1.BringToFront();
            buttonBack.Visible = false;
            buttonInne.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox focusTextBox = (TextBox)sender;
            focusTextBox.SelectionLength = 0;
            focusTextBox.SelectionStart = 0;

            labelF.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
