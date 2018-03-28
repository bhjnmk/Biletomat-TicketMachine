using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Biletomat
{
    public partial class OkresoweM : UserControl
    {
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        public OkresoweM()
        {
            InitializeComponent();

            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        public void OnEventL(Form frm)
        {
            if (EventLanguage != null)
                EventLanguage(frm, new EventArgs());
        }

        private void EventMethodL(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "                        dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "                        dd.MM.yyyy";

            label7.Text = "Season Ticket MZKZG";
            label8.Text = "Personal ticket, valid on ZTM Gdańsk, ZKM Gdynia and MZK Wejherowo vehicles on all days of the week.";
            label10.Text = "Insert the city card to the reader.";
            label5.Text = "Choose the type of season ticket:";
            buttonM.Text = "Monthly";
            button30.Text = "30-day";
            label3.Text = "Choose the start date of validity:";
            label4.Text = "Click on the icon to the right of the date below to view the calendar";
            label6.Text = "Valid until:";
            label2.Text = "Choose the type of ticket:";
            label9.Text = "Choose the type of ticket:";
            buttonN.Text = "Full price\n132 zl";
            buttonU.Text = "Reduced\n66 zl";
            buttonN2.Text = "Full price\n132 zl";
            buttonU2.Text = "Reduced\n66 zl";
            label1.Text = "Choose form of payment:";
            buttonK.Font = new Font("Microsoft Sans Serif", 24);
            buttonG.Font = new Font("Microsoft Sans Serif", 24);
            buttonK.Text = "Credit Card";
            buttonG.Text = "Cash";
            textBoxL.Text = "E";       
        }

        public void OnEventJ(Form frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd, d MMMM yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dddd, d MMMM yyyy";

            label7.Text = "Bilet okresowy metropolitalny MZKZG";
            label8.Text = "Imienny, obowiązujący w pojazdach ZTM Gdańsk, ZKM Gdynia i MZK Wejherowo, ważny we wszystkie dni tygodnia.";
            label10.Text = "Włóż kartę elektroniczną, na którą chcesz załadować bilet do czytnika.";
            label5.Text = "Wybierz rodzaj biletu okresowego:";
            buttonM.Text = "Miesięczny";
            button30.Text = "30-dniowy";
            label3.Text = "Wybierz dzień rozpoczęcia ważności:";
            label4.Text = "Kliknij na ikonę po prawej strony daty poniżej, aby wyświetlić kalendarz";
            label6.Text = "Ważny do:";
            label2.Text = "Wybierz rodzaj biletu:";
            label9.Text = "Wybierz rodzaj biletu:";
            buttonN.Text = "Normalny\n132 zł";
            buttonU.Text = "Ulgowy\n66 zł";
            buttonN2.Text = "Normalny\n132 zł";
            buttonU2.Text = "Ulgowy\n66 zł";
            label1.Text = "Wybierz formę płatności:";
            buttonK.Font = new Font("Microsoft Sans Serif", 30);
            buttonG.Font = new Font("Microsoft Sans Serif", 30);
            buttonK.Text = "Karta";
            buttonG.Text = "Gotówka";
            textBoxL.Text = "P";
        }

        //Ładowanie okna - ustawienie rozmiary 
        private void OkresoweM_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 640);
            panel0.Size = new Size(1024, 640);
            panel1.Size = new Size(1024, 640);
            panel2.Size = new Size(1024, 640);
            panel3.Size = new Size(1024, 640);
            
            panel0.Location = new Point(0, 0);
            panel1.Location = new Point(0, 110);
            panel2.Location = new Point(0, 110);
            panel3.Location = new Point(0, 1);

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(29);
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

        //Obsluga daty

        //Metoda ustawiająca dzień na ostatni dzień miesiąca
        public static DateTime GetLastDayOfMonth(DateTime dateTime)
        { 
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }

        //Ustawienie ważości 30dniowy/miesięczny
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(29);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //PRZYCISKI

        //Przycisk Karta Miejska
        private void buttonKM_Click(object sender, EventArgs e)
        {
            panel0.SendToBack();
            panel1.Visible = true;
            panel1.BringToFront();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk 30-dniowy
        private void button30_Click(object sender, EventArgs e)
        {
            panel30.Visible = true;
            panelM.Visible = false;
            panel1.SendToBack();
            panel2.Visible = true;
            panel2.BringToFront();
            buttonBack.Visible = true;
            MainForm.OnEventBBO(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            panel30.Visible = true;
            panelM.Visible = false;
            panel1.SendToBack();
            panel2.Visible = true;
            panel2.BringToFront();
            panel30.Visible = false;
            panelM.Visible = true;
            buttonBack.Visible = true;
            MainForm.OnEventBBO(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void ChoosenOne(string bilet, string kwota)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            string date_s = dateTimePicker1.Value.ToString("dddd, d MMMM yyyy");
            string date_e = dateTimePicker2.Value.ToString("dddd, d MMMM yyyy");
            string time_s;
            string time_e = "23:59";
            DateTime date = dateTimePicker1.Value.Date;
            //Ustalenie czy od dzisiaj, jeśli tak, to odpowiednia godzina
            if (date.Date == DateTime.Now.Date)
            {
                time_s = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                time_s = "00:00";
            }
            textBoxKwota.Text = kwota;

            //Wypisanie informacji
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = " Chosen 30-day ticket MZKZG:\n\n\n" + " Personal ticket, " + bilet + ", valid on all days of the week,\n in vehicles ZTM Gdańsk, ZKM Gdynia and MZK\n Wejherowo\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl\n";
                richTextBox2.Text = "\n\n\nValid from:\n" + date_s + " " + time_s + "\n\nValid until:\n" + date_e + " " + time_e;
            }
            else
            {
                richTextBox1.Text = " Wybrano bilet 30-dniowy metropolitalny MZKZG:\n\n\n" + " Imienny, " + bilet + ", ważny we wszystkie dni tygodnia,\n w pojazdach ZTM Gdańsk, ZKM Gdynia i MZK\n Wejherowo\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "__________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Kwota do zapłaty: " + textBoxKwota.Text + " zł\n";
                richTextBox2.Text = " \n\n\nWażny od:\n" + date_s + " " + time_s + "\n\nWażny do:\n" + date_e + " " + time_e;
            }

            MainForm.OnEventJ(true);
        }

        private void ChoosenOne2(string bilet, string kwota)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            string date_s;
            string date_e;
            string time_s;
            string time_e = "23:59";
            DateTime date = DateTime.Now.Date;
            DateTime date2;

            //Ustalenie czy od dzisiaj, jeśli tak, to odpowiednia godzina
            if (date.Day < 17)
            {
                if (textBoxL.Text == "E")
                {
                    time_s = DateTime.Now.ToString("hh:mm tt");
                    date_s = date.ToString("dddd, d MMMM yyyy");
                    date_e = GetLastDayOfMonth(date).ToString("dddd, d MMMM yyyy");
                }
                {
                    time_s = DateTime.Now.ToString("HH:mm");
                    date_s = date.ToString("dddd, d MMMM yyyy");
                    date_e = GetLastDayOfMonth(date).ToString("dddd, d MMMM yyyy");
                }
            }
            else
            {
                time_s = "00:00";
                date2 = GetLastDayOfMonth(date);
                date2 = date2.AddDays(1);
                date_s = date2.ToString("dddd, d MMMM yyyy");
                date_e = GetLastDayOfMonth(date2).ToString("dddd, d MMMM yyyy");
            }
            textBoxKwota.Text = kwota;

            //Wypisanie informacji
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = " Chosen monthly ticket MZKZG:\n\n\n" + " Personal ticket, " + bilet + ", valid on all days of the week,\n in vehicles ZTM Gdańsk, ZKM Gdynia and MZK\n Wejherowo\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl\n";
                richTextBox2.Text = "\n\n\nValid from:\n" + date_s + " " + time_s + "\n\nValid until:\n" + date_e + " " + time_e;
            }
            else
            {
                richTextBox1.Text = " Wybrano bilet miesięczny metropolitalny MZKZG:\n\n\n" + " Imienny, " + bilet + ", ważny we wszystkie dni tygodnia,\n w pojazdach ZTM Gdańsk, ZKM Gdynia i MZK\n Wejherowo\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "__________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Kwota do zapłaty: " + textBoxKwota.Text + " zł\n";
                richTextBox2.Text = " \n\n\nWażny od:\n" + date_s + " " + time_s + "\n\nWażny do:\n" + date_e + " " + time_e;
            }

            MainForm.OnEventJ(true);
        }

        //Przycisk normalny 30-dniowe
        private void buttonN_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxUN.Text = "full price";
            }
            else
            {
                textBoxUN.Text = "normalny";
            }
            ChoosenOne(textBoxUN.Text, "132");
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxUN.Text = "reduced";
            }
            else
            {
                textBoxUN.Text = "ulgowy";
            }
            ChoosenOne(textBoxUN.Text,"66");
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Miesieczne
        private void buttonN2_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxUN.Text = "full price";
            }
            else
            {
                textBoxUN.Text = "normalny";
            }
            ChoosenOne2(textBoxUN.Text, "132");
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonU2_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxUN.Text = "reduced";
            }
            else
            {
                textBoxUN.Text = "ulgowy";
            }
            ChoosenOne2(textBoxUN.Text, "66");
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk powrót
        private void buttonBack2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            MainForm.OnEventJ2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();
            buttonBack.Visible = false;
            MainForm.OnEventBBO2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Płatnośc - Karta
        private void buttonK_Click(object sender, EventArgs e)
        {
            double zaplac = Convert.ToDouble(textBoxKwota.Text);
            double ktory = 0;
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "Please, touch terminal with the card or insert the card into the payment terminal.");
                KartaForm nowyK = new KartaForm(zaplac, ktory);
                nowyK.OnEventL(true);
                nowyK.ShowDialog();
            }
            else
            {
                MessageBoxShow(3, "Proszę zbliżyć lub włóżyć kartę do terminalu płatniczego.");
                KartaForm nowyK = new KartaForm(zaplac, ktory);
                nowyK.OnEventJ(true);
                nowyK.ShowDialog();
            }
            MainForm.OnEventT2(true);
        }

        //Płatnosc - Gotówka
        private void buttonG_Click(object sender, EventArgs e)
        {
            double zaplac = Convert.ToDouble(textBoxKwota.Text);
            double ktory = 0;
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(8, "Please put the banknotes and/or coins into the appropriate holes. The ticket machine accepts: banknotes: PLN 20, PLN 10, coins: PLN 5, PLN 2, PLN 1, PLN 50 cents, PLN 20 cents and PLN 10 cents.");
                GotowkaForm nowyG = new GotowkaForm(zaplac, ktory);
                nowyG.OnEventL(true);
                nowyG.ShowDialog();
            }
            else
            {
                MessageBoxShow(8, "Proszę włożyć banknoty i/lub monety do odpowiednich otworów. Biletomat przyjmuje: banknoty: 20 zł, 10 zł, monety: 5 zł, 2 zł, 1 zł, 50 gr, 20 gr i 10 gr.");
                GotowkaForm nowyG = new GotowkaForm(zaplac, ktory);
                nowyG.OnEventJ(true);
                nowyG.ShowDialog();
            }
            MainForm.OnEventT2(true);
        }

        //Ustawienie okien
        private void OkresoweM_VisibleChanged(object sender, EventArgs e)
        {
            panel0.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

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
