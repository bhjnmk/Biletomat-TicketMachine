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
    public partial class Jedn_M : UserControl
    {
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        //Konstruktor 
        public Jedn_M()
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
            label4.Text = "Single tickets MZKZG";
            label5.Text = "Applies on ZTM Gdańsk and ZKM Gdynia and MZK Wejherowo vehicles.";
            label6.Text = "Applies on SKM Trains and on ZTM Gdańsk and ZKM Gdynia and MZK Wejherowo vehicles.";
            label10.Text = "Single fares\nvalid on standard\nbus line";
            label2.Text = "Single fares\nvalid on night, rapid,\nspecial and standard\nbus line";
            label20.Text = "24 hour\nmunicipal";
            label30.Text = "72 hour\nmunicipal";
            label28.Text = "24 hour rail and municipal of two organizers";
            label8.Text = "24 hour rail and municipal\nof all organizers";
            label36.Text = "72 hour rail and municipal\nof all organizers";
            label41.Text = "ZTM Gdańsk + Railway";
            label42.Text = "ZKM Gdynia + Railway";
            label43.Text = "MZK Wejherowo + Railway";
            label40.Text = "Amount to pay";
            label11.Text = "Full price 3.40 zl";
            label12.Text = "Reduced 1.70 zl";
            label13.Text = "Full price 4.40 zl";
            label14.Text = "Reduced 2.20 zl";
            label21.Text = "Full price 15 zl";
            label22.Text = "Reduced 7.50 zl";
            label31.Text = "Full price 30 zl";
            label32.Text = "Reduced 15 zl";
            

            label23.Text = "Full price 20 zl";
            label24.Text = "Reduced 10 zl";
            label29.Text = "Full price 20 zl";
            label37.Text = "Reduced 10 zl";
            label18.Text = "Full price 20 zl";
            label27.Text = "Reduced 10 zl";
            label25.Text = "Full price 23 zl";
            label26.Text = "Reduced 11,5 zl";
            label33.Text = "Full price 46 zl";
            label34.Text = "Reduced 23 zl";
            buttonZ.Text = "Pay";
            buttonInne.Text = "Rail and municipal tickets MZKZG";
        }

        public void OnEventJ(Form frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            textBoxL.Text = "P";
            label4.Text = "Bilety jednorazowe metropolitalne MZKZG";
            label5.Text = "Obowiązujące w pojazdach ZTM Gdańsk, ZKM Gdynia i MZK Wejherowo.";
            label6.Text = "Obowiązujące w pociągach SKM i pojazdach ZTM Gdańsk, ZKM Gdynia i MZK Wejherowo.";
            label10.Text = "Jednoprzejazdowy\nna linie zwykłe";
            label2.Text = "Jednoprzejazdowy\nna linie nocne,\npospieszne,\nspecjalne i zwykłe";
            label20.Text = "24-godzinny\nkomunalny";
            label30.Text = "72-godzinny\nkomunalny";
            label28.Text = "24-godzinny kolejowo-komunalny dwóch organizatorów";
            label8.Text = "24-godzinny kolejowo-komunalny\nwszystkich organizatorów";
            label36.Text = "72-godzinny kolejowo-komunalny\nwszystkich organizatorów";
            label41.Text = "ZTM Gdańsk + Kolej";
            label42.Text = "ZKM Gdynia + Kolej";
            label43.Text = "MZK Wejherowo + Kolej";
            label40.Text = "Do zapłaty";
            label11.Text = "Normalny 3,40 zł";
            label12.Text = "Ulgowy 1,70 zł";
            label13.Text = "Normalny 4,40 zł";
            label14.Text = "Ulgowy 2,20 zł";
            label21.Text = "Normalny 15 zł";
            label22.Text = "Ulgowy 7,50 zł";
            label31.Text = "Normalny 30 zł";
            label32.Text = "Ulgowy 15 zł";

            label23.Text = "Normalny 20 zł";
            label24.Text = "Ulgowy 10 zł";
            label29.Text = "Normalny 20 zł";
            label37.Text = "Ulgowy 10 zł";
            label18.Text = "Normalny 20 zł";
            label27.Text = "Ulgowy 10 zł";
            label25.Text = "Normalny 23 zł";
            label26.Text = "Ulgowy 11,5 zł";
            label33.Text = "Normalny 46 zł";
            label34.Text = "Ulgowy 23 zł";
            buttonZ.Text = "Zapłać";
            buttonInne.Text = "Bilety metropolitalne kolejowo-komunalne";
        }

        //Ustawienie wielkości okna i rozmieszczenie
        private void Jedn_M_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 640);
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 85);
            buttonBack.Visible = false;
        }

        //Przekazanie informacji do Platnosci
        public event EventHandler BiletMEvent;

        public double[] BiletMValue
        {
            get
            {
                double price = SetToPay();
                double which = 1; //jednorazowe
                double[] tickets = new double[20] { which, Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text) , Convert.ToInt16(textBox11.Text), Convert.ToInt16(textBox12.Text), Convert.ToInt16(textBox13.Text), Convert.ToInt16(textBox14.Text), Convert.ToInt16(textBox15.Text), Convert.ToInt16(textBox16.Text), Convert.ToInt16(textBox17.Text), Convert.ToInt16(textBox18.Text), price };
                return tickets;
            }
        }

        //Obluga przycisk zaplac  
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

                if (BiletMEvent != null)
                {
                    BiletMEvent(null, null);
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
            double[] price = new double[18] { 3.4, 1.7, 4.4, 2.2, 15, 7.5, 30, 15, 20, 10, 20, 10, 20, 10, 23, 11.5, 46, 23 };
            int[] tickets = new int[18] { Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text), Convert.ToInt16(textBox11.Text), Convert.ToInt16(textBox12.Text), Convert.ToInt16(textBox13.Text), Convert.ToInt16(textBox14.Text), Convert.ToInt16(textBox15.Text), Convert.ToInt16(textBox16.Text), Convert.ToInt16(textBox17.Text), Convert.ToInt16(textBox18.Text) };

            for (int i = 0; i < price.Length; i++)
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
            TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18 };
            int t = Convert.ToInt16(tbs[i - 1].Text);
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
            TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18 };
            int t = Convert.ToInt32(tbs[i - 1].Text);
            if (t == 0)
            {
                t = 0;
                tbs[i - 1].Text = t.ToString();
            }
            else
            {
                t = t - 1;
                tbs[i - 1].Text = t.ToString();
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

        private void buttonP11_Click(object sender, EventArgs e)
        {
            PlusMethod(11);
        }

        private void buttonM11_Click(object sender, EventArgs e)
        {
            MinusMethod(11);
        }

        private void buttonP12_Click(object sender, EventArgs e)
        {
            PlusMethod(12);
        }

        private void buttonM12_Click(object sender, EventArgs e)
        {
            MinusMethod(12);
        }

        private void buttonP13_Click(object sender, EventArgs e)
        {
            PlusMethod(13);
        }

        private void buttonM13_Click(object sender, EventArgs e)
        {
            MinusMethod(13);
        }

        private void buttonP14_Click(object sender, EventArgs e)
        {
            PlusMethod(14);
        }

        private void buttonM14_Click(object sender, EventArgs e)
        {
            MinusMethod(14);
        }

        private void buttonP15_Click(object sender, EventArgs e)
        {
            PlusMethod(15);
        }

        private void buttonM15_Click(object sender, EventArgs e)
        {
            MinusMethod(15);
        }

        private void buttonP16_Click(object sender, EventArgs e)
        {
            PlusMethod(16);
        }

        private void buttonM16_Click(object sender, EventArgs e)
        {
            MinusMethod(16);
        }

        private void buttonP17_Click(object sender, EventArgs e)
        {
            PlusMethod(17);
        }

        private void buttonM17_Click(object sender, EventArgs e)
        {
            MinusMethod(17);
        }

        private void buttonP18_Click(object sender, EventArgs e)
        {
            PlusMethod(18);
        }

        private void buttonM18_Click(object sender, EventArgs e)
        {
            MinusMethod(18);
        }

        //Wyzerowanie, gdy Home
        private void Jedn_M_VisibleChanged(object sender, EventArgs e)
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
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox40.Text = "";
            panel2.SendToBack();
            buttonBack.Visible = false;
        }

        //Pozostałe bilety
        private void buttonInne_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            buttonInne.Visible = false;
            buttonBack.Visible = true;
            label5.Visible = false;
            label6.Visible = true;
            panel6.Location = new Point(0, 530);
            MainForm.OnEventBB(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Powrót
        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.BringToFront();
            buttonBack.Visible = false;
            buttonInne.Visible = true;
            label6.Visible = false;
            label5.Visible = true;
            panel6.Location = new Point(0, 443);
            MainForm.OnEventBB2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void Jedn_M_LocationChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel6.Location = new Point(0, 443);
            panel1.BringToFront();
            buttonBack.Visible = false;
            buttonInne.Visible = true;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox focusTextBox = (TextBox)sender;
            focusTextBox.SelectionLength = 0;
            focusTextBox.SelectionStart = 0;

            labelF.Focus();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
