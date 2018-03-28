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
    public partial class Platnosc : UserControl
    {
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        public string[] nazwyG = new string[10] { "Bilet jednoprzejazdowy na linie zwykłe - normalny", "Bilet jednoprzejazdowy na linie zwykłe - ulgowy", "Bilet jednoprzejazdowy na linie nocne, pospieszne, specjalne i zwykłe - normalny", "Bilet jednoprzejazdowy na linie nocne, pospieszne, specjalne i zwykłe - ulgowy", "Bilet godzinny na linie zwykłe - normalny", "Bilet godzinny na linie zwykłe - ulgowy", "Bilet godzinny na linie nocne, pospieszne, specjalne i zwykłe - normalny", "Bilet godzinny na linie nocne, pospieszne, specjalne i zwykłe - ulgowy", "Bilet 24-godzinny na linie nocne, pospieszne, specjalne i zwykłe - normalny", "Bilet 24-godzinny na linie nocne, pospieszne, specjalne i zwykłe - ulgowy" };
        public string[] nazwyM = new string[18] { "Bilet jednoprzejazdowy na linie zwykłe - normalny", "Bilet jednoprzejazdowy na linie zwykłe - ulgowy", "Bilet jednoprzejazdowy na linie nocne, pospieszne, specjalne i zwykłe - normalny", "Bilet jednoprzejazdowy na linie nocne, pospieszne, specjalne i zwykłe - ulgowy", "Bilet 24-godzinny komunalny - normalny", "Bilet 24-godzinny komunalny - ulgowy", "Bilet 72-godzinny komunalny - normalny", "Bilet 72-godzinny komunalny - ulgowy", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: ZKM Gdynia + Kolej - normalny", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: ZKM Gdynia + Kolej - ulgowy", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: ZTM Gdańsk + Kolej - normalny", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: ZTM Gdańsk + Kolej - ulgowy", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: MZK Wejherowo + Kolej - normalny", "Bilet 24-godzinny kolejowo-komunalny dwóch organizatorów: MZK Wejherowo + Kolej - ulgowy", "Bilet 24-godzinny kolejowo-komunalny wszystkich organizatorów - normalny", "Bilet 24-godzinny kolejowo-komunalny wszystkich organizatorów - ulgowy", "Bilet 72-godzinny kolejowo-komunalny wszystkich organizatorów - normalny", "Bilet 72-godzinny kolejowo-komunalny wszystkich organizatorów - ulgowy" };
        public string[] nazwyGE = new string[10] { "Single fares valid on standard bus line - full price", "Single fares valid on standard bus line - reduced", "Single fares valid on night, rapid, special and standard bus line - full price", "Single fares valid on night, rapid, special and standard - reduced", "1 hour ticket valid on standard bus lines - full price", "1 hour ticket valid on standard bus lines - reduced", "1 hour ticket valid on night, rapid, special and standard bus lines - full price", "1 hour ticket valid on night, rapid, special and standard bus lines - reduced", "24 hour ticket valid on night, rapid, special and standard bus lines - full price", "24 hour ticket valid on night, rapid, special and standard bus line - reduced" };
        public string[] nazwyME = new string[18] { "Single fares valid on standard bus line - full price", "Single fares valid on standard bus line - reduced", "Single fares valid on night, rapid, special and standard bus line - full price", "Single fares valid on night, rapid, special and standard bus line - reduced", "24 hour municipal ticket - full price", "24 hour municipal ticket - reduced", "72 hour municipal ticket - full price", "72 hour municipal ticket - reduced", "24 hour rail and municipal ticket of two organizers: ZKM Gdynia + Railway - full price", "24 hour rail and municipal ticket of two organizers: ZKM Gdynia + Railway - reduced", "24 hour rail and municipal ticket of two organizers: ZTM Gdańsk + Railway - full price", "24 hour rail and municipal ticket of two organizers: ZTM Gdańsk + Railway - reduced", "24 hour rail and municipal ticket of two organizers: MZK Wejherowo + Railway - full price", "24 hour rail and municipal ticket of two organizers: MZK Wejherowo + Railway - reduced",  "24 hour rail and municipal ticket of all organizers - full price", "24 hour rail and municipal ticket of all organizers - reduced", "72 hour rail and municipal of all organizers - full price", "72 hour rail and municipal of all organizers - reduced" };


        //Konstruktor
        public Platnosc()
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
            label2.Text = "Choose form of payment:";
            buttonK.Font = new Font("Microsoft Sans Serif", 24);
            buttonG.Font = new Font("Microsoft Sans Serif", 24);
            buttonK.Text = "Credit Card";
            buttonG.Text = "Cash";
        }

        public void OnEventJ(Form frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            textBoxL.Text = "P";
            label2.Text = "Wybierz formę płatności:";
            buttonK.Font = new Font("Microsoft Sans Serif", 30);
            buttonG.Font = new Font("Microsoft Sans Serif", 30);
            buttonK.Text = "Karta";
            buttonG.Text = "Gotówka";
        }


        //Ustawienie rozmiaru okna
        private void Platnosc_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 620);
        }
 
        //Odebranie wartości z Jedn_G
        public double[] BiletGValue
        {
            set
            {
                panel1.Size = new Size(985, 355);
                panel2.Location = new Point(0, 458);
                textBoxKwota.Text = (value[value.Length - 1]).ToString("#,0.00");
                textBoxWhich.Text = (value[0]).ToString();
                double[] price = new double[10] { 3.2, 1.6, 4.2, 2.1, 3.8, 1.9, 4.8, 2.4, 13, 6.5 };
                richTextBox1.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox2.Font = new Font("Microsoft Sans Serif", 16);
                int number = 0;

                if (textBoxL.Text == "E")
                {
                    richTextBox1.Text = " Selected tickets ZKM Gdynia:\n\n";
                    richTextBox2.Text = "Sum:        Amount:\n\n";
                    for (int i = 1; i < (value.Length - 1); i++)
                    {
                        if (value[i] != 0)
                        {
                            double amount = price[i - 1] * value[i];
                            number = number + Convert.ToInt32(value[i]);
                            richTextBox1.Text = richTextBox1.Text + " " + nazwyGE[i - 1] + "\n";
                            if (Convert.ToInt32(value[i]) < 10)
                            {
                                if (amount < 10)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "          " + amount.ToString("#,0.00") + " zl\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "      " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "        " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                }
                            }
                            else
                            {
                                if (amount > 999)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "     " + value[i] + "  " + amount.ToString("#,0.00") + " zl\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "     " + value[i] + "      " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "        " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                }
                            }
                        }
                    }
                    richTextBox1.Text = richTextBox1.Text + "_____________________________________\n";
                    richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl";
                    textBoxN.Text = number.ToString();
                }
                else
                {
                    richTextBox1.Text = " Wybrane bilety ZKM Gdynia:\n\n";
                    richTextBox2.Text = "Ilość:        Kwota:\n\n";
                    for (int i = 1; i < (value.Length - 1); i++)
                    {
                        if (value[i] != 0)
                        {
                            double amount = price[i - 1] * value[i];
                            number = number + Convert.ToInt32(value[i]);
                            richTextBox1.Text = richTextBox1.Text + " " + nazwyG[i - 1] + "\n";
                            if (Convert.ToInt32(value[i]) < 10)
                            {
                                if (amount < 10)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "        " + amount.ToString("#,0.00") + " zł\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "    " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "      " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                }
                            }
                            else
                            {
                                if (amount > 999)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "  " + amount.ToString("#,0.00") + " zł\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "    " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "      " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                }
                            }
                        }
                    }
                    richTextBox1.Text = richTextBox1.Text + "_____________________________________\n";
                    richTextBox1.Text = richTextBox1.Text + " Do zapłaty: " + textBoxKwota.Text + " zł";
                    textBoxN.Text = number.ToString();

                }
            }
        }

        //Odebranie wartości z Jedn_M
        public double[] BiletMValue
        {
            set
            {
                panel1.Size = new Size(985, 445);
                panel2.Location = new Point(0, 510);

                textBoxKwota.Text = (value[value.Length - 1]).ToString("#,0.00");
                textBoxWhich.Text = (value[0]).ToString();

                double[] price = new double[18] { 3.4, 1.7, 4.4, 2.2, 15, 7.5, 30, 15, 20, 10, 20, 10, 20, 10, 23, 11.5, 46, 23 };
                int number = 0;
                int sum = 0;

                richTextBox1.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox2.Font = new Font("Microsoft Sans Serif", 16);
                richTextBox1.Size = new Size(800, 440);
                richTextBox2.Location = new Point(800, 0);

                if (value[9] != 0 || value[10] != 0 || value[11] != 0 || value[12] != 0 || value[13] != 0 || value[14] != 0)
                {
                    richTextBox1.Font = new Font("Microsoft Sans Serif", 14);
                    richTextBox2.Font = new Font("Microsoft Sans Serif", 14);
                    richTextBox1.Size = new Size(825, 440);
                    richTextBox2.Location = new Point(825, 0);
                }

                if (textBoxL.Text == "E")
                {
                    richTextBox1.Text = " Selected tickets MZKZG:\n\n";
                    richTextBox2.Text = "Sum:        Amount:\n\n";
                    int a = value.Length;
                    for (int i = 1; i < (value.Length - 1); i++)
                    {
                        if (value[i] != 0)
                        {
                            double amount = price[i - 1] * value[i];
                            number = number + Convert.ToInt32(value[i]);
                            sum++;
                            richTextBox1.Text = richTextBox1.Text + " " + nazwyME[i - 1] + "\n";
                            if (Convert.ToInt32(value[i]) < 10)
                            {
                                if (amount < 10)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "          " + amount.ToString("#,0.00") + " zl\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "      " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "        " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                }
                            }
                            else
                            {
                                if (amount > 999)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "     " + value[i] + "   " + amount.ToString("#,0.00") + " zl\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "     " + value[i] + "      " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "        " + amount.ToString("#,0.00") + " zl\n";
                                    }
                                }
                            }
                        }
                    }
                    richTextBox1.Text = richTextBox1.Text + "_____________________________________\n";
                    richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl";
                    textBoxN.Text = number.ToString();
                    if (sum > 14)
                    {
                        richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                        richTextBox2.Font = new Font("Microsoft Sans Serif", 12);
                    }
                }
                else
                {
                    richTextBox1.Text = " Wybrane bilety metropolitalne MZKZG:\n\n";
                    richTextBox2.Text = "Ilość:        Kwota:\n\n";
                    int a = value.Length;
                    for (int i = 1; i < (value.Length - 1); i++)
                    {
                        if (value[i] != 0)
                        {
                            double amount = price[i - 1] * value[i];
                            number = number + Convert.ToInt32(value[i]);
                            sum++;
                            richTextBox1.Text = richTextBox1.Text + " " + nazwyM[i - 1] + "\n";
                            if (Convert.ToInt32(value[i]) < 10)
                            {
                                if (amount < 10)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "        " + amount.ToString("#,0.00") + " zł\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "    " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "      " + value[i] + "      " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                }
                            }
                            else
                            {
                                if (amount > 999)
                                {
                                    richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "  " + amount.ToString("#,0.00") + " zł\n";
                                }
                                else
                                {
                                    if (amount > 99)
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "    " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                    else
                                    {
                                        richTextBox2.Text = richTextBox2.Text + "    " + value[i] + "      " + amount.ToString("#,0.00") + " zł\n";
                                    }
                                }
                            }
                        }
                    }
                    richTextBox1.Text = richTextBox1.Text + "_____________________________________\n";
                    richTextBox1.Text = richTextBox1.Text + " Do zapłaty: " + textBoxKwota.Text + " zł";
                    textBoxN.Text = number.ToString();
                    if (sum > 14)
                    {
                        richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                        richTextBox2.Font = new Font("Microsoft Sans Serif", 12);
                    }
                }
            }
        }

        //Metoda do MessageBox
        public void MessageBoxShow(int time, string tekst)
        {
            Form w = new Form() { Size = new Size(0, 0) };
            w.BringToFront();
            Task.Delay(TimeSpan.FromSeconds(time))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            MessageBox.Show(w, tekst);
        }

        //Przycisk Karta
        private void buttonK_Click(object sender, EventArgs e)
        {
            double zaplac = Convert.ToDouble(textBoxKwota.Text);
            double ktory = Convert.ToDouble(textBoxWhich.Text);

            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "Please, touch terminal with the card or insert the card into the payment terminal.");
                KartaForm nowyK = new KartaForm(zaplac, ktory, Convert.ToInt32(textBoxN.Text));
                nowyK.OnEventL(true);
                nowyK.ShowDialog();
            }
            else
            {
                MessageBoxShow(3, "Proszę zbliżyć lub włóżyć kartę do terminalu płatniczego.");
                KartaForm nowyK = new KartaForm(zaplac, ktory, Convert.ToInt32(textBoxN.Text));
                nowyK.OnEventJ(true);
                nowyK.ShowDialog();
            }
            MainForm.OnEventT2(true);
        }

        //Przycisk Gotowka
        private void buttonG_Click(object sender, EventArgs e)
        {
            double zaplac = Convert.ToDouble(textBoxKwota.Text);
            double ktory = Convert.ToDouble(textBoxWhich.Text);

            if (textBoxL.Text == "E")
            {
                MessageBoxShow(8, "Please put the banknotes and/or coins into the appropriate holes. The ticket machine accepts: banknotes: PLN 20, PLN 10, coins: PLN 5, PLN 2, PLN 1, PLN 50 cents, PLN 20 cents and PLN 10 cents.");
                GotowkaForm nowyG = new GotowkaForm(zaplac, ktory, Convert.ToInt32(textBoxN.Text));
                nowyG.OnEventL(true);
                nowyG.ShowDialog();
            }
            else
            {
                MessageBoxShow(8, "Proszę włożyć banknoty i/lub monety do odpowiednich otworów. Biletomat przyjmuje: banknoty: 20 zł, 10 zł, monety: 5 zł, 2 zł, 1 zł, 50 gr, 20 gr i 10 gr.");
                GotowkaForm nowyG = new GotowkaForm(zaplac, ktory, Convert.ToInt32(textBoxN.Text));
                nowyG.OnEventJ(true);
                nowyG.ShowDialog();
            }
            MainForm.OnEventT2(true);
        }

        private void richTextBox_Enter(object sender, EventArgs e)
        {
            RichTextBox focusRichTextBox = (RichTextBox)sender;
            focusRichTextBox.SelectionLength = 0;
            focusRichTextBox.SelectionStart = 0;

            labelF.Focus();
        }

        private void richtextBox_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

    }
}
