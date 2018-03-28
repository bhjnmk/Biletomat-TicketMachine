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
    public partial class GotowkaForm : Form
    {
        public double Kwota;
        public double Which;
        public double Number;

        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        //Konstruktor
        public GotowkaForm(double kwota, double which)
        {
            InitializeComponent();
            Kwota = kwota;
            Which = which;
            timer1.Interval = 3000;
            textBoxK.Text = Kwota.ToString("#,0.00");
            textBoxP.Text = textBoxK.Text;

            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        public GotowkaForm(double kwota, double which, int number)
        {
            InitializeComponent();
            Kwota = kwota;
            Which = which;
            Number = number;
            timer1.Interval = number * 2000;

            textBoxK.Text = Kwota.ToString("#,0.00");
            textBoxP.Text = textBoxK.Text;

            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        private void GotowkaForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
            timer2.Start();
            MainForm.OnEventT2(true);
        }

        //Obsluga jezyka
        public void OnEventL(bool frm)
        {
            if (EventLanguage != null)
                EventLanguage(frm, new EventArgs());
        }

        private void EventMethodL(object sender, EventArgs e)
        {
            textBoxL.Text = "E";
            label2.Text = "Amount to pay:";
            label1.Text = "Left to pay:";
            button1.Text = "Cancel";
            textBox1.Text = "zl";
            textBox2.Text = "zl";
            richTextBox1.Text = "Please put banknotes or coins in the appropriate holes.";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public void OnEventJ(bool frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            textBoxL.Text = "P";
            label2.Text = "Kwota do zapłaty:";
            label1.Text = "Pozostało:";
            button1.Text = "Anuluj";
            textBox1.Text = "zł";
            textBox2.Text = "zł";
            richTextBox1.Text = "Proszę umieścić banknoty lub monety w odpowiednich otworach.";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        //Metoda na wyskakiwanie MessageBox
        public void MessageBoxShow(int time, string tekst)
        {
            Form w = new Form() { Size = new Size(0, 0) };
            w.BringToFront();
            Task.Delay(TimeSpan.FromSeconds(time))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            MessageBox.Show(w, tekst);
        }

        //Metoda Przyciski
        public void CashButtons(double cash)
        {
            double kwota = Convert.ToDouble(textBoxP.Text);
            kwota = kwota - cash;
            if (kwota <= 0)
            {
                textBoxR.Text = (-kwota).ToString();
                if (kwota == 0)
                {
                    if (Which == 1)
                    {
                        MainForm.OnEventEndBC11(this);
                        timer1.Start();
                    }
                    if (Which == 0)
                    {
                        MainForm.OnEventEndBC22(this);
                        timer1.Start();
                    }
                    this.Visible = false;
                }
                else
                {
                    if (textBoxL.Text == "E")
                    {
                        richTextBox1.Text = "\n\nChange: " + (-kwota).ToString("#,0.00") + " zl";
                        richTextBox1.SelectAll();
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        richTextBox1.DeselectAll();
                        textBoxP.Text = "0";
                        MessageBoxShow(2, "Please wait...");
                    }
                    else
                    {
                        richTextBox1.Text = "\n\nReszta: " + (-kwota).ToString("#,0.00") + " zł";
                        richTextBox1.SelectAll();
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        richTextBox1.DeselectAll();
                        textBoxP.Text = "0";
                        MessageBoxShow(2, "Proszę czekać...");
                    }

                    if (Which == 1)
                    {
                        timer2.Stop();
                        MainForm.OnEventEndBCR(this);
                        timer1.Start();
                    }

                    if (Which == 0)
                    {
                        timer2.Stop();
                        MainForm.OnEventEndBCR2(this);
                        timer1.Start();
                    }
                    this.Visible = false;
                }
            }
            else
            {
                textBoxP.Text = kwota.ToString("#,0.00");
                timer2.Stop();
                timer2.Start();
            }
        }

        //Przyciski imitujące wrzucanie monet/banknotów
        private void button20z_Click(object sender, EventArgs e)
        {
            CashButtons(20);
        }

        private void button10z_Click(object sender, EventArgs e)
        {
            CashButtons(10);
        }

        private void button5z_Click(object sender, EventArgs e)
        {
            CashButtons(5);
        }

        private void button2z_Click(object sender, EventArgs e)
        {
            CashButtons(2);
        }

        private void button1z_Click(object sender, EventArgs e)
        {
            CashButtons(1);
        }

        private void button50g_Click(object sender, EventArgs e)
        {
            CashButtons(0.5);
        }

        private void button20g_Click(object sender, EventArgs e)
        {
            CashButtons(0.2);
        }

        private void button10g_Click(object sender, EventArgs e)
        {
            CashButtons(0.1);
        }

        //Powrót
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            timer2.Stop();
            MainForm.OnEventT(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Which == 1)
            {
                if (Convert.ToDouble(textBoxR.Text) > 0)
                {
                    MainForm.OnEventEndCR(this);
                }
                else
                {
                    MainForm.OnEventEndC(this);
                }
            }

            if (Which == 0)
            {
                if (Convert.ToDouble(textBoxR.Text) > 0)
                {
                    MainForm.OnEventEndCR2(this);
                }
                else
                {
                    MainForm.OnEventEndC2(this);
                }
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

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            RichTextBox focusRichTextBox = (RichTextBox)sender;
            focusRichTextBox.SelectionLength = 0;
            focusRichTextBox.SelectionStart = 0;

            labelF.Focus();
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "No activity, transaction is being canceled...");
                timer2.Stop();
            }
            else
            {
                MessageBoxShow(3, "Brak aktywności, anulowanie transakcji...");
                timer2.Stop();
            }
            MainForm.OnEventTick(true);
        }
    }
}
