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
    public partial class OkresoweG : UserControl
    {
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        public OkresoweG()
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

            textBoxL.Text = "E";
            label7.Text = "Season Ticket ZKM Gdynia";
            label10.Text = "Insert the city card to the reader.";
            label12.Text = "Choose the type of season ticket:";
            buttonM.Text = "Monthly";
            button30.Text = "30-day";
            label4.Text = "Choose the type of ticket you want to load:";
            label5.Text = "Choose bus route type:";
            label8.Text = "Choose city/municipality:";
            label9.Text = "Choose cities/municipalities:";
            label3.Text = "Choose the start date of validity:";
            label11.Text = "Click on the icon to the right of the date below to view the calendar";
            label6.Text = "Valid until:";
            label2.Text = "Choose the type of ticket:";
            label13.Text = "Choose the type of ticket:";
            label1.Text = "Choose form of payment:";
            buttonK.Font = new Font("Microsoft Sans Serif", 24);
            buttonG.Font = new Font("Microsoft Sans Serif", 24);
            buttonK.Text = "Credit Card";
            buttonG.Text = "Cash";

            buttonIP.Text = "Personal ticket\nValid monday to friday";
            buttonIA.Text = "Personal ticket\nValid on all weekdays";
            buttonO.Text = "Ticket to bearer\nValid on all weekdays";
            buttonR1.Text = "Standard within Gdynia city limits";
            buttonR2.Text = "Night, rapid and standard within Gdynia city limits";
            buttonR3.Text = "Night, rapid and standard within - choice of city/municipality";
            buttonR4.Text = "Night, rapid and standard within - choice of cities/municipalities";
            buttonR5.Text = "Night, rapid and standard within public transport network";
            buttonM1.Text = "Sopot city";
            buttonM2.Text = "Rumia city";
            buttonM3.Text = "Kosakowo municipality";
            buttonM4.Text = "Zukowo municipality";
            buttonM5.Text = "Szemud municipality";
            buttonM6.Text = "Wejherowo municipality";
            buttonM7.Text = "Rumia, Reda and Wejherowo city";
            buttonM8.Text = "Wejherowo municipality and Rumia city";
            buttonM3.Font = new Font("Microsoft Sans Serif", 11);
            buttonM4.Font = new Font("Microsoft Sans Serif", 11);
            buttonM5.Font = new Font("Microsoft Sans Serif", 11);
            buttonM6.Font = new Font("Microsoft Sans Serif", 11);
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

            textBoxL.Text = "P";
            label7.Text = "Bilet okresowy ZKM Gdynia";
            label10.Text = "Włóż kartę elektroniczną, na którą chcesz załadować bilet do czytnika.";
            label12.Text = "Wybierz rodzaj biletu okresowego:";
            buttonM.Text = "Miesięczny";
            button30.Text = "30-dniowy";
            label4.Text = "Wybierz rodzaj biletu, jaki chcesz załadować:";
            label5.Text = "Wybierz rodzaj linii:";
            label8.Text = "Wybierz miasto/gminę:";
            label9.Text = "Wybierz miasta/gminy:";
            label3.Text = "Wybierz dzień rozpoczęcia ważności:";
            label11.Text = "Kliknij na ikonę po prawej strony daty poniżej, aby wyświetlić kalendarz";
            label6.Text = "Ważny do:";
            label2.Text = "Wybierz rodzaj biletu:";
            label13.Text = "Wybierz rodzaj biletu:";
            label1.Text = "Wybierz formę płatności:";
            buttonK.Font = new Font("Microsoft Sans Serif", 30);
            buttonG.Font = new Font("Microsoft Sans Serif", 30);
            buttonK.Text = "Karta";
            buttonG.Text = "Gotówka";

            buttonIP.Text = "Imienny\nWażny od poniedziałku do piątku";
            buttonIA.Text = "Imienny\nWażny we wszystkie dni tygodnia";
            buttonO.Text = "Na Okaziciela\nWażny we wszystkie dni tygodnia";
            buttonR1.Text = "Zwykłe w granicach Gdyni";
            buttonR2.Text = "Nocne, pospieszne oraz zwykłe w granicach Gdyni";
            buttonR3.Text = "Nocne, pospieszne oraz zwykłe w granicach - wybór miasta/gminy";
            buttonR4.Text = "Nocne, pospieszne oraz zwykłe w granicach - wybór miast/gmin";
            buttonR5.Text = "Nocne, pospieszne oraz zwykłe w obrębie sieci komunikacyjnej";
            buttonM1.Text = "Sopot";
            buttonM2.Text = "Rumia";
            buttonM3.Text = "Gm. Kosakowo";
            buttonM4.Text = "Gm. Żukowo";
            buttonM5.Text = "Gm. Szemud";
            buttonM6.Text = "Gm. Wejherowo";
            buttonM7.Text = "Rumia, Reda\ni miasto Wejherowo";
            buttonM8.Text = "Gm. Wejherowo\ni Rumia";

            buttonM3.Font = new Font("Microsoft Sans Serif", 12);
            buttonM4.Font = new Font("Microsoft Sans Serif", 12);
            buttonM5.Font = new Font("Microsoft Sans Serif", 12);
            buttonM6.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void OkresoweG_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 640);
            panel0.Size = new Size(1024, 640);
            panel1.Size = new Size(1024, 560);
            panel2.Size = new Size(1024, 560);
            panel3.Size = new Size(1024, 560);
            panel4.Size = new Size(1024, 640);

            panel0.Location = new Point(0, 0);
            panel1.Location = new Point(0, 78);
            panel2.Location = new Point(0, 78);
            panel3.Location = new Point(1, 78);
            panel4.Location = new Point(0, 1);
            panelM1.Location = new Point(250, 350);
            panelM2.Location = new Point(251, 350);

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(29);
            label100.Size = new Size(964, 48);
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

        //Meotda - wypisanie koncowych informacji
        private void EndInfo()
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.BringToFront();
            textBoxKwota.Text = textBoxKN.Text;

            string date_s = dateTimePicker1.Value.ToString("dddd, d MMMM yyyy");
            string date_e = dateTimePicker2.Value.ToString("dddd, d MMMM yyyy");
            string time_s;
            string time_e = "23:59";
            DateTime date = dateTimePicker1.Value.Date;
            //Ustalenie czy od dzisiaj, jeśli tak, to odpowiednia godzina
            if (date.Date == DateTime.Now.Date)
            {
                if (textBoxL.Text == "E")
                {
                    time_s = DateTime.Now.ToString("hh:mm tt");
                }
                {
                    time_s = DateTime.Now.ToString("HH:mm");
                }
            }
            else
            {
                time_s = "00:00";
            }

            //Wypisanie informacji
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = " Chosen 30-day ticket ZKM Gdynia:\n\n\n " + textBoxWB0.Text + ", " + textBoxWB1.Text + ", " + textBoxWB2.Text + "\n\n";
                richTextBox1.Text = richTextBox1.Text + " Bus route type:\n" + " " + textBoxWB.Text + "\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl\n";
                richTextBox2.Text = "\n\n\nValid from:\n" + date_s + " " + time_s + "\n\nValid until:\n" + date_e + " " + time_e;
            }
            else
            {
                richTextBox1.Text = " Wybrano bilet 30-dniowy ZKM Gdynia:\n\n\n" + " " + textBoxWB0.Text + ", " + textBoxWB1.Text + ", " + textBoxWB2.Text + "\n\n";
                richTextBox1.Text = richTextBox1.Text + " Rodzaj linii:\n" + " " + textBoxWB.Text + "\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Kwota do zapłaty: " + textBoxKwota.Text + " zł\n";
                richTextBox2.Text = "\n\n\nWażny od:\n" + date_s + " " + time_s + "\n\nWażny do:\n" + date_e + " " + time_e;
            }

            MainForm.OnEventJ(true);
        }

        private void EndInfo2()
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.BringToFront();
            textBoxKwota.Text = textBoxKN.Text;

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
            
            //Wypisanie informacji
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = " Chosen monthly ticket ZKM Gdynia:\n\n\n " + textBoxWB0.Text + ", " + textBoxWB1.Text + ", " + textBoxWB2.Text + "\n\n";
                richTextBox1.Text = richTextBox1.Text + " Bus route type:\n" + " " + textBoxWB.Text + "\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Amount to pay: " + textBoxKwota.Text + " zl\n";
                richTextBox2.Text = "\n\n\nValid from:\n" + date_s + " " + time_s + "\n\nValid until:\n" + date_e + " " + time_e;
            }
            else
            {
                richTextBox1.Text = " Wybrano bilet miesięczny ZKM Gdynia:\n\n\n" + " " + textBoxWB0.Text + ", " + textBoxWB1.Text + ", " + textBoxWB2.Text + "\n\n";
                richTextBox1.Text = richTextBox1.Text + " Rodzaj linii:\n" + " " + textBoxWB.Text + "\n\n\n\n";
                richTextBox1.Text = richTextBox1.Text + "_______________________________________\n";
                richTextBox1.Text = richTextBox1.Text + " Kwota do zapłaty: " + textBoxKwota.Text + " zł\n";
                richTextBox2.Text = "\n\n\nWażny od:\n" + date_s + " " + time_s + "\n\nWażny do:\n" + date_e + " " + time_e;
            }

            MainForm.OnEventJ(true);
        }

        //Sprawdzenie, który bilet został wybrany - metody dla odpowiednich if
        private void allIf(string nor, string ulg)
        {
            if (textBoxL.Text == "E")
            {
                if (ulg == "Brak możliwości zakupu")
                {
                    buttonN.Text = "Full price\n" + nor + " zl";
                    buttonU.Text = "Reduced\n" + "No purchase option";
                    buttonN2.Text = "Full price\n" + nor + " zl";
                    buttonU2.Text = "Reduced\n" + "No purchase option";
                }
                else
                {
                    buttonN.Text = "Full price\n" + nor + " zl";
                    buttonU.Text = "Reduced\n" + ulg + " zl";
                    buttonN2.Text = "Full price\n" + nor + " zl";
                    buttonU2.Text = "Reduced\n" + ulg + " zl";
                }
                
            }
            else
            {
                if (ulg == "Brak możliwości zakupu")
                {
                    buttonN.Text = "Normalny\n" + nor + " zł";
                    buttonU.Text = "Ulgowy\n" + "Brak możliwości zakupu";
                    buttonN2.Text = "Normalny\n" + nor + " zł";
                    buttonU2.Text = "Ulgowy\n" + "Brak możliwości zakupu";
                }
                else
                {
                    buttonN.Text = "Normalny\n" + nor + " zł";
                    buttonU.Text = "Ulgowy\n" + ulg + " zł";
                    buttonN2.Text = "Normalny\n" + nor + " zł";
                    buttonU2.Text = "Ulgowy\n" + ulg + " zł";
                }
            }
            textBoxKN.Text = nor;
            textBoxKU.Text = ulg;
        }

        private void if1(string nor, string ulg)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB.Text = "standard within Gdynia city limits";
            }
            else
            {
                textBoxWB.Text = "zwykłe w granicach Gdyni";
            }
            allIf(nor, ulg);
        }

        private void if2(string nor, string ulg)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB.Text = "night, rapid and standard within Gdynia city limits";
            }
            else
            {
                textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gdyni";
            }
            allIf(nor, ulg);
        }

        private void if3(string nor, string ulg)
        {
            allIf(nor, ulg);

            if (textBoxM.Text == "11")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Sopot city limits";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Sopotu";
                }
                
            }

            if (textBoxM.Text == "12")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Rumia city limits";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Rumi";
                }
            }

            if (textBoxM.Text == "13")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Kosakowo municipality";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gminy Kosakowo";
                }
            }

            if (textBoxM.Text == "14")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Zukowo municipality";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gminy Żukowo";
                }
            }

            if (textBoxM.Text == "15")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Szemud municipality";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gminy Szemud";
                }
            }

            if (textBoxM.Text == "16")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Wejherowo municipality";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gminy Wejherowo";
                }
            }
        }

        private void if4(string nor, string ulg)
        {
            allIf(nor, ulg);

            if (textBoxM.Text == "21")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Rumia, Reda & Wejherowo city limits";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Rumi, Redy i miasta Wejherowa";
                }
            }

            if (textBoxM.Text == "22")
            {
                if (textBoxL.Text == "E")
                {
                    textBoxWB.Text = "night, rapid and standard within Wejherowo municipality & Rumia city limits";
                }
                else
                {
                    textBoxWB.Text = "nocne, pospieszne i zwykłe w granicach Gminy Wejherowo i Rumi";
                }
            }
        }

        private void if5(string nor, string ulg)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB.Text = "night, rapid and standard within public transport network (including routes G, N1, 101 i 171)";
            }
            else
            {
                textBoxWB.Text = "nocne, pospieszne i zwykłe w obrębie sieci komunikacyjnej (w tym linie G, N1, 101, 171)";
            }
            allIf(nor, ulg);
        }

        //Metoda wynaczania rodzaju i ceny biletu
        private void ChosenOne()
        {
            buttonBack1.Visible = true;
            buttonBack1.BringToFront();
            MainForm.OnEventBBO(true);

            //Sprawdzenie, ktory bilet zostal wybrany
            if (textBoxIO.Text == "1")
            {
                buttonU.Enabled = true;
                buttonU2.Enabled = true;
                if (textBoxL.Text == "E")
                {
                    textBoxWB0.Text = "Personal ticket";
                    textBoxWB2.Text = "valid monday to friday";
                }
                else
                {
                    textBoxWB0.Text = "Imienny";
                    textBoxWB2.Text = "ważny od poniedziałku do piątku";
                }
      
                if (textBoxR.Text == "1")
                {
                    if1("72", "36");
                }

                if (textBoxR.Text == "2")
                {
                    if2("86", "43");
                }

                if (textBoxR.Text == "3")
                {
                    if3("58", "29");
                }

                if (textBoxR.Text == "4")
                {
                    if4("74", "37");
                }

                if (textBoxR.Text == "5")
                {
                    if5("96", "48");
                }
            }

            //imienny, wazny we wszystkie dni tygodnia
            if (textBoxIO.Text == "2")
            {
                buttonU.Enabled = true;
                buttonU2.Enabled = true;
                if (textBoxL.Text == "E")
                {
                    textBoxWB0.Text = "Personal ticket";
                    textBoxWB2.Text = "valid on all weekdays";
                }
                else
                {
                    textBoxWB0.Text = "Imienny";
                    textBoxWB2.Text = "ważny we wszystkie dni tygodnia";
                }
                
                if (textBoxR.Text == "1")
                {
                    if1("82", "41");
                }

                if (textBoxR.Text == "2")
                {
                    if2("94", "47");
                }

                if (textBoxR.Text == "3")
                {
                    if3("64", "32");
                }

                if (textBoxR.Text == "4")
                {
                    if4("84", "42");
                }

                if (textBoxR.Text == "5")
                {
                    if5("104", "52");
                }
            }

            //na okaziciela, wazny we wszystkie dni tygodnia
            if (textBoxIO.Text == "3")
            {
                buttonU.Enabled = false;
                buttonU2.Enabled = false;
                if (textBoxL.Text == "E")
                {
                    textBoxWB0.Text = "Ticket to bearer";
                    textBoxWB2.Text = "valid on all weekdays";
                    buttonU.Text = "Reduced\nNo purchase option";
                    buttonU2.Text = "Reduced\nNo purchase option";
                }
                else
                {
                    textBoxWB0.Text = "Na okaziciela";
                    textBoxWB2.Text = "ważny we wszystkie dni tygodnia";
                    buttonU.Text = "Ulgowy\nBrak możliwości zakupu";
                    buttonU2.Text = "Ulgowy\nBrak możliwości zakupu";
                }

                if (textBoxR.Text == "1")
                {
                    if1("92", "Brak możliwości zakupu");
                }

                if (textBoxR.Text == "2")
                {
                    if2("107", "Brak możliwości zakupu");
                }

                if (textBoxR.Text == "3")
                {
                    if3("75", "Brak możliwości zakupu");
                }

                if (textBoxR.Text == "4")
                {
                    if4("97", "Brak możliwości zakupu");
                }

                if (textBoxR.Text == "5")
                {
                    if5("117", "Brak możliwości zakupu");
                }
            }
            if (textBoxL.Text == "E")
            {
                if (textBoxT.Text == "M")
                {
                    textBoxT.Text = "monthly";
                }
                else
                {
                    textBoxT.Text = "30-day";
                }
                label100.Text = "Chosen " + textBoxT.Text + " ticket: " + textBoxWB0.Text + ", " + textBoxWB2.Text + ". Bus route type: " + textBoxWB.Text + ".";
            }
            else
            {
                if (textBoxT.Text == "M")
                {
                    textBoxT.Text = "miesięczny";
                }
                else
                {
                    textBoxT.Text = "30-dniowy";
                }
                label100.Text = "Wybrano " + textBoxT.Text + " bilet: " + textBoxWB0.Text + ", " + textBoxWB2.Text + ". Rodzaj linii: " + textBoxWB.Text + ".";
            }
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

        private void NextStep()
        {
            panel3.Visible = true;
            panel2.Visible = false;
            ChosenOne();
            panel3.BringToFront();
            buttonBack2.Visible = true;
            buttonBack2.BringToFront();
            MainForm.OnEventJ(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przyciski

        //Przycisk 'karta miejska'
        private void buttonKM_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            panelDni.Visible = true;
            panelDni.BringToFront();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk Imienne Pn-Pt
        private void buttonIP_Click(object sender, EventArgs e)
        {
            panelRodzaj.Visible = true;
            panelRodzaj.BringToFront();
            textBoxIO.Text = "1";
            buttonIA.Enabled = false;
            buttonO.Enabled = false;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk imienne all
        private void buttonIA_Click(object sender, EventArgs e)
        {
            panelRodzaj.Visible = true;
            panelRodzaj.BringToFront();
            textBoxIO.Text = "2";
            buttonIP.Enabled = false;
            buttonO.Enabled = false;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk na okaziciela
        private void buttonO_Click(object sender, EventArgs e)
        {
            panelRodzaj.Visible = true;
            panelRodzaj.BringToFront();
            textBoxIO.Text = "3";
            buttonIP.Enabled = false;
            buttonIA.Enabled = false;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przyciski Rodzaj
        private void buttonR1_Click(object sender, EventArgs e)
        {
            textBoxR.Text = "1";
            NextStep();
        }

        private void buttonR2_Click(object sender, EventArgs e)
        {
            textBoxR.Text = "2";
            NextStep();
        }

        private void buttonR3_Click(object sender, EventArgs e)
        {
            panelM1.Visible = true;
            panelM1.BringToFront();
            textBoxR.Text = "3";
            buttonR1.Enabled = false;
            buttonR2.Enabled = false;
            buttonR4.Enabled = false;
            buttonR5.Enabled = false;
            buttonB1.Visible = false;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonR4_Click(object sender, EventArgs e)
        {
            panelM2.Visible = true;
            panelM2.BringToFront();
            textBoxR.Text = "4";
            buttonR1.Enabled = false;
            buttonR2.Enabled = false;
            buttonR3.Enabled = false;
            buttonR5.Enabled = false;
            buttonB1.Visible = false;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonR5_Click(object sender, EventArgs e)
        {
            textBoxR.Text = "5";
            NextStep();
        }

        //Przyciski Miasto
        private void buttonM1_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "11";
            NextStep();
        }

        private void buttonM2_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "12";
            NextStep();
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "13";
            NextStep();
        }

        private void buttonM4_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "14";
            NextStep();
        }

        private void buttonM5_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "15";
            NextStep();
        }

        private void buttonM6_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "16";
            NextStep();
        }

        private void buttonM7_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "21";
            NextStep();
        }

        private void buttonM8_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "22";
            NextStep();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            panelDni.Visible = true;
            panelDni.BringToFront();
            panelM.Visible = false;
            panel30.Visible = true;
            textBoxT.Text = "30";
            MainForm.OnEventBBO(true);
            buttonBack1.Visible = true;
            buttonBack1.BringToFront();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            panelDni.Visible = true;
            panelDni.BringToFront();
            panelM.Visible = true;
            panel30.Visible = false;
            textBoxT.Text = "M";
            MainForm.OnEventBBO(true);
            buttonBack1.Visible = true;
            buttonBack1.BringToFront();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk normalany
        private void ButtonN_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB1.Text = "full price";
            }
            else
            {
                textBoxWB1.Text = "normalny";
            }
            
            EndInfo();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        //Przycisk ulgowy
        private void ButtonU_Click(object sender, EventArgs e)
        { 
            if (textBoxL.Text == "E")
            {
                textBoxWB1.Text = "reduced";
            }
            else
            {
                textBoxWB1.Text = "ulgowy";
            }
            
            EndInfo();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB1.Text = "full price";
            }
            else
            {
                textBoxWB1.Text = "normalny";
            }

            EndInfo2();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonU2_Click(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                textBoxWB1.Text = "reduced";
            }
            else
            {
                textBoxWB1.Text = "ulgowy";
            }

            EndInfo2();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();
            MainForm.OnEventBBO2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();
            buttonBack1.Visible = true;
            buttonBack1.BringToFront();
            MainForm.OnEventJ2(true);
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            panel3.BringToFront();
            buttonBack2.Visible = true;
            buttonBack2.BringToFront();
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Visible = true;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonB21_Click(object sender, EventArgs e)
        {
            panelM1.Visible = false;
            buttonR1.Enabled = true;
            buttonR2.Enabled = true;
            buttonR3.Enabled = true;
            buttonR4.Enabled = true;
            buttonR5.Enabled = true;
            buttonB1.Visible = true;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

        private void buttonB22_Click(object sender, EventArgs e)
        {
            panelM2.Visible = false;
            buttonR1.Enabled = true;
            buttonR2.Enabled = true;
            buttonR3.Enabled = true;
            buttonR4.Enabled = true;
            buttonR5.Enabled = true;
            buttonB1.Visible = true;
            MainForm.OnEventT2(true);
            MainForm.OnEventT(true);
        }

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

        //Zmiana widocznosci - ustalenie kolejnosci okna
        private void OkresoweG_VisibleChanged(object sender, EventArgs e)
        {
            panel0.Visible = true;
            panel0.BringToFront();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            panelDni.Visible = true;
            panelRodzaj.Visible = false;
            panelM1.Visible = false;
            panelM2.Visible = false;
            buttonO.Enabled = true;
            buttonIP.Enabled = true;
            buttonIA.Enabled = true;
            buttonB1.Visible = true;
            buttonR1.Enabled = true;
            buttonR2.Enabled = true;
            buttonR3.Enabled = true;
            buttonR4.Enabled = true;
            buttonR5.Enabled = true;
        }

    }
}
