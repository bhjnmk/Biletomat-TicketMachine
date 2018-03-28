using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Timers;

namespace Biletomat
{
    
    public partial class MainForm : Form
    {
        //timer event
        public static event EventHandler EventT;
        public static event EventHandler EventT2;
        public static event EventHandler EventTick;

        //Last window events
        public static event EventHandler EventEndC;
        public static event EventHandler EventEndC2;
        public static event EventHandler EventEndCK;
        public static event EventHandler EventEndCK2;
        public static event EventHandler EventEndCR;
        public static event EventHandler EventEndCR2;

        public static event EventHandler EventEndBC;
        public static event EventHandler EventEndBC2;
        public static event EventHandler EventEndBC11;
        public static event EventHandler EventEndBC22;
        public static event EventHandler EventEndBCR;
        public static event EventHandler EventEndBCR2;

        //BackButtons Events
        public static event EventHandler EventBB;
        public static event EventHandler EventBB2;
        public static event EventHandler EventBBO;
        public static event EventHandler EventBBO2;

        //Language events
        public static event EventHandler EventJ;
        public static event EventHandler EventJ2;

        int richTimer;

        //Konstruktor
        public MainForm()
        {
            InitializeComponent();

            //Info z jedn
            jedn_G1.BiletGEvent += MainWindow_Bevent;
            jedn_M1.BiletMEvent += MainWindow_Mevent;

            //timer event
            EventT += new EventHandler(EventMethodT);
            EventT2 += new EventHandler(EventMethodT2);
            EventTick += new EventHandler(buttonH_Click);

            //Last window events
            EventEndC += new EventHandler(EventMethodEndC);
            EventEndC2 += new EventHandler(EventMethodEndC2);
            EventEndCK += new EventHandler(EventMethodEndCK);
            EventEndCK2 += new EventHandler(EventMethodEndCK2);
            EventEndCR += new EventHandler(EventMethodEndCR);
            EventEndCR2 += new EventHandler(EventMethodEndCR2);

            EventEndBC += new EventHandler(EventMethodEndBC);
            EventEndBC2 += new EventHandler(EventMethodEndBC2);
            EventEndBC11 += new EventHandler(EventMethodEndBC11);
            EventEndBC22 += new EventHandler(EventMethodEndBC22);
            EventEndBCR += new EventHandler(EventMethodEndBCR);
            EventEndBCR2 += new EventHandler(EventMethodEndBCR2);

            //BackButtons Events
            EventBB += new EventHandler(EventMethodBB);
            EventBB2 += new EventHandler(EventMethodBB2);
            EventBBO += new EventHandler(EventMethodBBO);
            EventBBO2 += new EventHandler(EventMethodBBO2);

            //Language Events
            EventJ += new EventHandler(EventMethodJ);
            EventJ2 += new EventHandler(EventMethodJ2);

            timer1.Start();

            CultureInfo ci = new CultureInfo("pl-PL");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
        }

        //Ładowanie okna, odpowiednie rozmieszczeni paneli i wielkość okna
        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = new Size(1024, 768);
            MinimumSize = new Size(1024, 768);
            MaximumSize = new Size(1024, 768);
            panelG.Size = new Size(1024, 640);
            panelJG.Size = new Size(1024, 640);
            panelJM.Size = new Size(1024, 640);
            panelOM.Size = new Size(1024, 640);
            panelOG.Size = new Size(1024, 640);
            panelOst1.Size = new Size(1024, 640);
            
            panelG.Location = new Point(0, 120);
            panelJG.Location = new Point(0, 120);
            panelJM.Location = new Point(0, 120);
            panelOM.Location = new Point(0, 120);
            panelOst1.Location = new Point(0, 120);
            panelOG.Location = new Point(0, 120);
            CenterToScreen();
            timer3.Enabled = false;
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

        //Metoda uzupełniająca infoForm w odpowiedni tekst
        private string InfoMethod()
        {
            string infoText;
            if (textBoxL.Text == "E")
            {
                //Eng ver
                infoText = "Aby zmienić język kliknij na odpowiedniej fladze/To change language click on the appropriate flag.\n\n";
                infoText = infoText + "To buy a ticket, press the button showing the corresponding category.\n\n";
                infoText = infoText + " In order to buy a single ticket, select '+' next to the ticket you want to buy to increase its number and '-' if you want to reduce it. Then press the 'Pay' button and select the payment type. Follow the instructions on the screen.\n\n";
                infoText = infoText + " In order to buy a season ticket, insert the city card into the reader. Then select the appropriate ticket and start date. Then choose the type of payment and follow the instructions on the screen.\n\n";
                infoText = infoText + "A monthly ticket is valid for a given month, the purchase of a ticket is possible until the 16th of each month, after that date you can buy a ticket only for the following month. A 30-day ticket can be purchased no earlier than 29 days before the ticket validity.\n\n";
                infoText = infoText + "For more information about tickets, please visit the ZKM Gdynia website at www.zkmgdynia.pl. Information on public transport is also available at the Hotline numbers (open 24 hours): 801 174 194 (single-pulse connection) or 695 174 194 - for mobile phone users (call cost according to the caller's tariff).\n\n";
                infoText = infoText + " In case of any problems with the operation of the machine please contact the service at: XXX-XXX-XXX.\n\n";
                infoText = infoText + " Closing the information window will occur spontaneously after 30 seconds, if you want to close the window before that time, press the 'OK' button.";
            }
            else
            {
                //Pol ver
                infoText = "To change language click on the appropriate flag/Aby zmienić język kliknij na odpowiedniej fladze.\n\n";
                infoText = infoText + "Aby kupić bilet naciśnij na przycisk przedstawiający odpowiadającą mu kategorię.\n\n";
                infoText = infoText + "W celu zakupu biletu jednorazowego wybierz '+' przy bilecie, który chcesz kupić, żeby zwiększyć jego liczbę i '-' jeśli chcesz ją zmniejszyć. Następnie naciśnij przycisk 'Zapłać' i wybierz rodzaj płatności. Postępuj zgodnie z instrukcjami wyświetlanymi na ekranie.\n\n";
                infoText = infoText + "W celu zakupu biletu okresowego włóż kartę miejską do czytnika. Wybierz rodzaj biletu - miesięczny czy 30 dniowy. Następnie wybierz odpowiedni bilet i datę rozpoczęcia. Następnie wybierz rodzaj płatności i postępuj zgodnie z instrukcjami wyświetlanymi na ekranie.\n\n";
                infoText = infoText + "Bilet miesięczny obowiązuje na dany miesiąc, zakup biletu jest możliwy do 16. dnia każdego miesiąca, po tym terminie można kupić bilet wyłącznie na kolejny miesiąc. Natomiast Bilet 30-dniowy można kupować nie wcześniej, niż na 29 dni przed początkiem ważności biletu.\n\n";
                infoText = infoText + "Po więcej informacji na temat biletów zapraszamy na stronę internetową ZKM Gdynia pod adresem: www.zkmgdynia.pl. Informacje o komunikacji miejskiej dostępne są także pod numerami Infolinii (czynnymi całą dobę): 801 174 194 (połączenie jednoimpulsowe) lub 695 174 194 - dla użytkowników telefonów komórkowych (koszt połączenia wg taryfy osoby dzwoniącej).\n\n";
                infoText = infoText + "W razie problemów z działaniem automatu skontaktuj się z serwisem pod numerem: XXX-XXX-XXX.\n\n";
                infoText = infoText + "Zamknięcie okna informacji nastąpi samoistnie po 30 sekundach, jeśli chcesz zamknąć okno wcześniej naciśnij przycisk 'OK'.";
            }
            return infoText;
        }

        public static void OnEventTick(bool x)
        {
            if (EventTick != null)
                EventTick(x, new EventArgs());
        }

        //Po 30s bezaktywności powrót do home
        private void EventMethodT(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        public static void OnEventT(bool x)
        {
            if (EventT != null)
                EventT(x, new EventArgs());
        }

        private void EventMethodT2(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        public static void OnEventT2(bool x)
        {
            if (EventT2 != null)
                EventT2(x, new EventArgs());
        }


        //Obsluga jezyka, eventy

        //dezaktywacja przyciskow jezyka, gdy okno platnosci
        private void EventMethodJ(object sender, EventArgs e)
        {
            buttonPL.Visible = false;
            buttonPL2.Visible = true;
            buttonENG.Visible = false;
            buttonENG2.Visible = true;
        }

        public static void OnEventJ(bool x)
        {
            if (EventJ != null)
                EventJ(x, new EventArgs());
        }

        //aktywacja przyciskow jezyka, gdy okno platnosci
        private void EventMethodJ2(object sender, EventArgs e)
        {
            buttonPL.Visible = true;
            buttonPL2.Visible = false;
            buttonENG.Visible = true;
            buttonENG2.Visible = false;
        }

        public static void OnEventJ2(bool x)
        {
            if (EventJ2 != null)
                EventJ2(x, new EventArgs());
        }

        //Obsługa ostatniego komunikatu
        //Gotówka bez reszty, jednorazowe
        private void EventMethodEndC(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the printed tickets.\nThank you for using our services.\nPlease come again!";
            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz wydrukowane bilety.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndC(Form frm)
        {
            if (EventEndC != null)
                EventEndC(frm, new EventArgs());
        }

        //Gotówka z resztą, jednorazowe
        private void EventMethodEndCR(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the printed tickets and the change.\nThank you for using our services.\nPlease come again!";

            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz wydrukowane bilety i resztę.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndCR(Form frm)
        {
            if (EventEndCR != null)
                EventEndCR(frm, new EventArgs());
        }   

        //Karta, jednorazowe
        private void EventMethodEndCK(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the printed tickets and confirmation of payment.\nThank you for using our services.\nPlease come again!";
            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz wydrukowane bilety i potwierdzenie płatności.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndCK(Form frm)
        {
            if (EventEndCK != null)
                EventEndCK(frm, new EventArgs());
        }

        //Gotówka, bez reszty - okresowe
        private void EventMethodEndC2(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the confirmation of purchase.\nThank you for using our services.\nPlease come again!";
            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz potwierdzenie zakupu.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndC2(Form frm)
        {
            if (EventEndC2 != null)
                EventEndC2(frm, new EventArgs());
        }

        //Gotówka, z resztą - okresowe
        private void EventMethodEndCR2(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the confirmation of purchase and the change.\nThank you for using our services.\nPlease come again!";
            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz potwierdzenie zakupu i resztę.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndCR2(Form frm)
        {
            if (EventEndCR2 != null)
                EventEndCR2(frm, new EventArgs());
        }

        //Karta, okresowe
        private void EventMethodEndCK2(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            if (textBoxL.Text == "E")
            {
                richTextBox1.Text = "\n\n\n\n\nReceive the confirmation of purchase and confirmation of payment.\nThank you for using our services.\nPlease come again!";
            }
            else
            {
                richTextBox1.Text = "\n\n\n\n\nOdbierz potwierdzenie zakupu i potwierdzenie płatności.\nDziękujemy za skorzystanie z naszych usług.\nZapraszamy ponownie!";
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        public static void OnEventEndCK2(Form frm)
        {
            if (EventEndCK2 != null)
                EventEndCK2(frm, new EventArgs());
        }


        //Komunikat o wydruku
        //Karta, jednorazowe
        private void EventMethodEndBC(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlesse wait, tickets and payment confirmed are being printed..";
            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydruk biletów i potwierdzenia płatności...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBC(Form frm)
        {
            if (EventEndBC != null)
                EventEndBC(frm, new EventArgs());
        }

        //Gotówka, bez reszty - jednorazowe
        private void EventMethodEndBC11(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlesse wait, tickets are being printed...";
            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydruk biletów...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBC11(Form frm)
        {
            if (EventEndBC11 != null)
                EventEndBC11(frm, new EventArgs());
        }

        //Gotówka, z resztą - jednorazowe
        private void EventMethodEndBCR(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlease wait, tickets are being printed\nand the change are being given...";

            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydawanie reszty i druk biletów...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBCR(Form frm)
        {
            if (EventEndBCR != null)
                EventEndBCR(frm, new EventArgs());
        }

        //Karta -  okresowe
        private void EventMethodEndBC2(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlesse wait, confirmation of purchase and payment confirmation are being printed...";
            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydruk potwierdzenia zakupu i potwierdzenia płatności...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBC2(Form frm)
        {
            if (EventEndBC2 != null)
                EventEndBC2(frm, new EventArgs());
        }

        //Gotówka, bez reszty - okresowe
        private void EventMethodEndBC22(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlesse wait, confirmation of purchase is being printed...";
            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydruk potwierdzenia zakupu...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBC22(Form frm)
        {
            if (EventEndBC22 != null)
                EventEndBC22(frm, new EventArgs());
        }

        //Gotówka, z resztą - okresowe
        private void EventMethodEndBCR2(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelOG.Visible = false;
            panelOst1.Visible = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            if (textBoxL.Text == "E")
            {
                richTextBox2.Text = "\n\n\n\n\n\nPlease wait, confirmation of purchase is being printed\nand the change is given...";
            }
            else
            {
                richTextBox2.Text = "\n\n\n\n\n\nProszę czekać, trwa wydawanie reszty i druk potwierdzenia zakupu...";
            }
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.DeselectAll();
            buttonH.Enabled = false;
            buttonI.Enabled = false;
        }

        public static void OnEventEndBCR2(Form frm)
        {
            if (EventEndBCR2 != null)
                EventEndBCR2(frm, new EventArgs());
        }


        //Eventy - przyciski back

        //Metoda - ukrycie buttonBackJG0 i buttonBackJM0
        private void EventMethodBB(object sender, EventArgs e)
        {
            buttonBackJG0.SendToBack();
            buttonBackJM0.SendToBack();
        }

        //Przekazanie z jedn_g i jedn_m - ukrycie "back"
        public static void OnEventBB(bool x)
        {
            if (EventBB != null)
                EventBB(x, new EventArgs());
        }

        //Metoda - pokazanie buttonBackJG0 i buttonBackJM0
        private void EventMethodBB2(object sender, EventArgs e)
        {
            buttonBackJG0.BringToFront();
            buttonBackJM0.BringToFront();
        }

        //Przekazanie z jedn_g i jedn_m - pokazanie "back"
        public static void OnEventBB2(bool x)
        {
            if (EventBB2 != null)
                EventBB2(x, new EventArgs());
        }

        //Metoda - ukrycie buttonBackOM0
        private void EventMethodBBO(object sender, EventArgs e)
        {
            buttonBackOM0.SendToBack();
            buttonBackOG0.SendToBack();
        }

        //Przekazanie z okresowe - ukrycie "back"
        public static void OnEventBBO(bool x)
        {
            if (EventBBO != null)
                EventBBO(x, new EventArgs());
        }

        //Metoda - pokazanie buttonBackOM0
        private void EventMethodBBO2(object sender, EventArgs e)
        {
            buttonBackOM0.BringToFront();
            buttonBackOG0.BringToFront();
        }

        //Przekazanie z okresowe_g - pokazanie "back"
        public static void OnEventBBO2(bool x)
        {
            if (EventBBO2 != null)
                EventBBO2(x, new EventArgs());
        }


        //Przekazanie miedzy platnosc i jedn_g
        void MainWindow_Bevent(object sender, EventArgs e)
        {
            this.platnosc1.BiletGValue = this.jedn_G1.BiletGValue;
            buttonBackJG.BringToFront();
            buttonBackJG0.SendToBack();
        }

        //Przekazanie miedzy platnosc i jedn_m
        void MainWindow_Mevent(object sender, EventArgs e)
        {
            this.platnosc2.BiletMValue = this.jedn_M1.BiletMValue;
            buttonBackJM.BringToFront();
            buttonBackJM0.SendToBack();
        }

        //PRZYCISKI
        //Obsluga przyciskow jezykowych
        private void buttonENG_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-GB");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            textBoxL.Text = "E";
            buttonJG.Text = "SINGLE TICKETS";
            buttonJM.Text = "SINGLE TICKETS MZKZG";
            buttonOG.Text = "SEASON TICKETS";
            buttonOM.Text = "SEASON TICKETS MZKZG";
            okresoweM1.OnEventL(this);
            okresoweG1.OnEventL(this);
            jedn_G1.OnEventL(this);
            jedn_M1.OnEventL(this);
            platnosc1.OnEventL(this);
            platnosc2.OnEventL(this);
        }

        private void buttonPL_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("pl-PL");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            textBoxL.Text = "P";
            buttonJG.Text = "BILETY JEDNORAZOWE";
            buttonJM.Text = "BILETY JEDNORAZOWE METROPOLITALNE";
            buttonOG.Text = "BILETY OKRESOWE";
            buttonOM.Text = "BILET OKRESOWY METROPOLITALNY";
            okresoweM1.OnEventJ(this);
            okresoweG1.OnEventJ(this);
            jedn_G1.OnEventJ(this);
            jedn_M1.OnEventJ(this);
            platnosc1.OnEventJ(this);
            platnosc2.OnEventJ(this);
        }

        //Przycisk Jednorazowe - ZKM Gdynia
        private void buttonJG_Click(object sender, EventArgs e)
        {
            panelG.Visible = false;
            panelJG.Visible = true;
            panelJM.Visible = false;
            panelOM.Visible = false;
            panelOst1.Visible = false;
            OnEventBB2(true);
            OnEventT(true);
        }

        //Przycisk Jednorazowe - Metropolitalne
        private void buttonJM_Click(object sender, EventArgs e)
        {
            panelG.Visible = false;
            panelJG.Visible = false;
            panelJM.Visible = true;
            panelOM.Visible = false;
            panelOst1.Visible = false;
            panelOG.Visible = false;
            OnEventBB2(true);
            OnEventT(true);
        }

        //Przycisk Okresowe - ZKM Gdynia
        private void buttonOG_Click(object sender, EventArgs e)
        {
            panelOG.Visible = true;
            panelG.Visible = false;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOM.Visible = false;
            panelOst1.Visible = false;
            OnEventBBO2(true);
            OnEventT(true);
        }

        //Przycisk Okresowe - Metropolitalne
        private void buttonOM_Click(object sender, EventArgs e)
        {
            panelG.Visible = false;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOM.Visible = true;
            panelOst1.Visible = false;
            panelOG.Visible = false;
            OnEventBBO2(true);
            OnEventT(true);
        }

        //Przycisk - Home
        private void buttonH_Click(object sender, EventArgs e)
        {
            panelG.Visible = true;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOM.Visible = false;
            panelOst1.Visible = false;
            panelOG.Visible = false;
            OnEventJ2(true);
            OnEventT2(true);
            timer2.Stop();
        }

        //Przycisk Info
        private void buttonI_Click(object sender, EventArgs e)
        {
            string infoText = InfoMethod();
            InfoForm.ShowBox(infoText,"Info");
            OnEventT2(true);
        }

        //Przyciski Powrót dla J_Gdynia
        private void buttonBackJG0_Click(object sender, EventArgs e)
        {
            panelJG.Visible = false;
            panelG.Visible = true;
            buttonBackJG0.SendToBack();
            buttonBackJG.BringToFront();
            OnEventT2(true);
            OnEventT(true);
        }

        private void buttonBackJG_Click(object sender, EventArgs e)
        {
            jedn_G1.BringToFront();
            platnosc1.SendToBack();
            buttonBackJG.SendToBack();
            buttonBackJG0.BringToFront();
            jedn_G1.Location = new Point(1, 0);
            jedn_G1.Location = new Point(0, 0);
            OnEventJ2(true);
            OnEventT2(true);
            OnEventT(true);
        }

        //Przyciski Powrót dla J_Metro
        private void buttonBackJM0_Click(object sender, EventArgs e)
        {
            panelJM.Visible = false;
            panelG.Visible = true;
            buttonBackJM0.SendToBack();
            buttonBackJM.BringToFront();
            OnEventT2(true);
            OnEventT(true);
        }

        private void buttonBackJM_Click(object sender, EventArgs e)
        {
            jedn_M1.BringToFront();
            platnosc2.SendToBack();
            buttonBackJM.SendToBack();
            buttonBackJM0.BringToFront();
            jedn_M1.Location = new Point(1, 0);
            jedn_M1.Location = new Point(0, 0);
            OnEventJ2(true);
            OnEventT2(true);
            OnEventT(true);
        }

        //Przycisk Powrót dla O_Metro
        private void buttonBackOM0_Click(object sender, EventArgs e)
        {
            panelOM.Visible = false;
            panelG.Visible = true;
            OnEventT2(true);
            OnEventT(true);
        }

        //Przycisk powrót dla O_gdynia
        private void buttonBackOG0_Click(object sender, EventArgs e)
        {
            panelOG.Visible = false;
            panelG.Visible = true;
            OnEventT2(true);
            OnEventT(true);
        }

        //Końcowy textbox - kliknięcie - początkowe ustawienie okien
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            panelG.Visible = true;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = false;
            panelOM.Visible = false;
            panelOG.Visible = false;
            timer2.Stop();
            buttonPL.Visible = true;
            buttonPL2.Visible = false;
            buttonENG.Visible = true;
            buttonENG2.Visible = false;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            timer3.Stop();

            if (textBoxL.Text == "E")
            {
                BookForm bookfrm = new BookForm();
                bookfrm.OnEventL(true);
                bookfrm.ShowDialog();
            }
            else
            {
                BookForm bookfrm = new BookForm();
                bookfrm.OnEventJ(true);
                bookfrm.ShowDialog();
            }
        }

        //Ustawianie kolejnosci okien, po zmianie ich widocznosci

        //Główne okno
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            panelG.Visible = true;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOst1.Visible = false;
            panelOM.Visible = false;
            panelOG.Visible = false;
        }

        //Panel dla J_Gdynia
        private void panelJG_VisibleChanged(object sender, EventArgs e)
        {
            jedn_G1.BringToFront();
            jedn_G1.Visible = false;
            jedn_G1.Visible = true;
            platnosc1.SendToBack();
            buttonBackJG0.BringToFront();
        }

        //Panel dla J_Metro
        private void panelJM_VisibleChanged(object sender, EventArgs e)
        {
            jedn_M1.BringToFront();
            jedn_M1.Visible = false;
            jedn_M1.Visible = true;
            platnosc2.SendToBack();
            buttonBackJM0.BringToFront();
        }

        //Timer odliczanie czasu rzeczywistego
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (textBoxL.Text == "E")
            {
                labelDate.Text = dateTime.ToString("dddd, d MMMM yyyy\nh:mm:ss tt");
            }
            else
            {
                labelDate.Text = dateTime.ToString("dddd, d MMMM yyyy\nHH:mm:ss");
            }
        }

        //Zmiana tekstu dla ostatniego richBoxa
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer2.Start();
        }

        //Timer przejscie do poczatku z ostatniego okna
        private void timer2_Tick(object sender, EventArgs e)
        {
            richTimer = richTimer + 3;
            if (richTimer == 3)
            {
                if (textBoxL.Text == "E")
                {
                    BookForm bookfrm = new BookForm();
                    bookfrm.OnEventL(true);
                    bookfrm.ShowDialog();
                }
                else
                {
                    BookForm bookfrm = new BookForm();
                    bookfrm.OnEventJ(true);
                    bookfrm.ShowDialog();
                }
                
            }
            
            if (richTimer == 9)
            {
                panelOst1.Visible = false;
                panelJG.Visible = false;
                panelJM.Visible = false;
                panelOM.Visible = false;
                panelOG.Visible = false;
                panelG.Visible = true;
                buttonPL.Visible = true;
                buttonPL2.Visible = false;
                buttonENG.Visible = true;
                buttonENG2.Visible = false;
                buttonH.Enabled = true;
                buttonI.Enabled = true;
                timer2.Stop();
                richTimer = 0;
            }            
        }

        private void buttonPL2_Click(object sender, EventArgs e)
        {
            MessageBoxShow(3, "Zmiana języka nie jest dostępna na tym etapie zakupu.");
            OnEventT2(true);
            OnEventT(true);
        }

        private void buttonENG2_Click(object sender, EventArgs e)
        {
            MessageBoxShow(3, "Changing the language is not available at this stage of the purchase.");
            OnEventT2(true);
            OnEventT(true);
        }

        private void richTextBox_Enter(object sender, EventArgs e)
        {
            RichTextBox focusRichTextBox = (RichTextBox)sender;
            focusRichTextBox.SelectionLength = 0;
            focusRichTextBox.SelectionStart = 0;

            label2.Focus();
        }

        private void richtextBox_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (textBoxL.Text == "E")
            {
                MessageBoxShow(3, "No activity for 30 seconds, back to home page.");
            }
            else
            {
                MessageBoxShow(3, "Brak aktywności przez 30 sekund, powrót do ekranu początkowego.");
            }
            panelG.Visible = true;
            panelJG.Visible = false;
            panelJM.Visible = false;
            panelOM.Visible = false;
            panelOst1.Visible = false;
            panelOG.Visible = false;
            OnEventJ2(true);
            timer3.Stop();
        }
    }
}
