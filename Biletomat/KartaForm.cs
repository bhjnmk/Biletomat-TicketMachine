using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletomat
{
    public partial class KartaForm : Form
    {
        public double Kwota;
        public double Which;
        public int Number;

        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        //Konstruktor
        public KartaForm(double kwota, double which)
        {
            InitializeComponent();
            Kwota = kwota;
            Which = which;
            timer1.Interval = 4000;
            textBoxK.Text = Kwota.ToString("#,0.00");

            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        public KartaForm(double kwota, double which, int number)
        {
            InitializeComponent();
            Kwota = kwota;
            Which = which;
            Number = number;
            timer1.Interval = number*2000;
            textBoxK.Text = Kwota.ToString("#,0.00");

            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        private void KartaForm_Load(object sender, EventArgs e)
        {
            buttonC.Enabled = true;
            buttonZ.Enabled = true;
            timer2.Start();
            MainForm.OnEventT2(true);
        }

        private void EventMethodL(object sender, EventArgs e)
        {
            textBoxL.Text = "E";
        }

        public void OnEventL(bool frm)
        {
            if (EventLanguage != null)
                EventLanguage(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            textBoxL.Text = "P";
        }

        public void OnEventJ(bool frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        //Metoda na wyskakiwanie MessageBox
        public void MessageBoxShow(int time, string tekst)
        {
            Form w = new Form() { Size = new Size(0, 0) };
            w.StartPosition = FormStartPosition.CenterParent;
            w.BringToFront();
            Task.Delay(TimeSpan.FromSeconds(time))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            MessageBox.Show(w, tekst);
        }

        //Metoda do zatwierdzenia płatnosci
        public void AcceptPay()
        {
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "Please wait, the transaction is being confirmed...");
                MessageBoxShow(3, "Transaction confirmed.");
            }
            else
            {
                MessageBoxShow(3, "Proszę czekać, trwa potwierdzanie transakcji...");
                MessageBoxShow(3, "Transakcja potwierdzona.");
            }
               
            if (Which == 1)
            {
                timer1.Start();
                MainForm.OnEventEndBC(this);
            }
            if (Which == 0)
            {
                timer1.Start();
                MainForm.OnEventEndBC2(this);
            }
            this.Visible = false;
        }

        //Przycisk zbliżeniowo
        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;
            buttonZ.Enabled = false;
            if (Kwota>=50)
            {
                if (textBoxL.Text == "E")
                {
                    MessageBoxShow(2, "Enter your PIN and confirm.");
                }
                else
                {
                    MessageBoxShow(2, "Podaj PIN i zatwierdź.");
                }
                p_1.Enabled = true;
                p_2.Enabled = true;
                p_3.Enabled = true;
                p_4.Enabled = true;
                p_5.Enabled = true;
                p_6.Enabled = true;
                p_7.Enabled = true;
                p_8.Enabled = true;
                p_9.Enabled = true;
                p_0.Enabled = true;
                ButtonK.Enabled = true;
                buttonP.Enabled = true;
                timer2.Stop();
                timer2.Start();
            }
            else
            {
                AcceptPay();
                timer2.Stop();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            p_1.Enabled = true;
            p_2.Enabled = true;
            p_3.Enabled = true;
            p_4.Enabled = true;
            p_5.Enabled = true;
            p_6.Enabled = true;
            p_7.Enabled = true;
            p_8.Enabled = true;
            p_9.Enabled = true;
            p_0.Enabled = true;
            ButtonK.Enabled = true;
            buttonP.Enabled = true;
            buttonZ.Enabled = false;
            buttonC.Enabled = false;

            if (textBoxL.Text == "E")
            {
                MessageBoxShow(2, "Enter your PIN and confirm. ");
            }
            else
            {
                MessageBoxShow(2, "Podaj PIN i zatwierdź.");
            }
            timer2.Stop();
            timer2.Start();
        }

        //Przycisk Potwierdz
        private void buttonP_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text == "" || textBoxPIN.TextLength < 4)
            {
                if (textBoxL.Text == "E")
                {
                    MessageBoxShow(2, "Please enter your PIN (4-12 characters).");
                }
                else
                {
                    MessageBoxShow(2, "Proszę podać PIN (4-12 znaków).");
                }
                timer2.Stop();
                timer2.Start();
            }
            else
            {
                AcceptPay();
                timer2.Stop();
            }   
        }

        //Przycisk Anuluj
        private void buttonA_Click(object sender, EventArgs e)
        {
            this.Close();
            timer2.Stop();
            MainForm.OnEventT(true);
        }

        //Przycisk Popraw
        private void ButtonK_Click(object sender, EventArgs e)
        {
            textBoxPIN.Text = "";
            timer2.Stop();
            timer2.Start();
        }

        //Metoda do przycisków 0-9
        public void p_09()
        {
            if (textBoxPIN.TextLength == 12)
            {
                textBoxPIN.Text = textBoxPIN.Text;
                if (textBoxL.Text == "E")
                {
                    MessageBoxShow(2, "Max 12 digits, enter your PIN (4-12 digits)");
                }
                else
                {
                    MessageBoxShow(2, "Max 12 cyfr, podaj kod PIN (4-12 cyfr)");
                }
                textBoxPIN.Text = "";
            }
            else
            {
                textBoxPIN.Text = textBoxPIN.Text + "*";
            }
            timer2.Stop();
            timer2.Start();
        }

        //Obsługa przycisków 0-9
        private void p_1_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_2_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_3_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_4_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_5_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_6_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_7_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_8_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_9_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void p_0_Click(object sender, EventArgs e)
        {
            p_09();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Which == 1)
            {
                MainForm.OnEventEndCK(this);
            }
            else
            {
                MainForm.OnEventEndCK2(this);
            }
            timer1.Stop();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "No activity, transaction is being canceled...");
            }
            else
            {
                MessageBoxShow(3, "Brak aktywności, anulowanie transakcji...");
            }
            timer2.Stop();
            MainForm.OnEventTick(true);
        }
    }
 }

