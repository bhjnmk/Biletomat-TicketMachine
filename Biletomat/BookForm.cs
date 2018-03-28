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
    public partial class BookForm : Form
    {
        int FormTimer = 120;
        public event EventHandler EventLanguage;
        public event EventHandler EventJezyk;

        public BookForm()
        {
            InitializeComponent();
            timer1.Start();
            EventLanguage += new EventHandler(EventMethodL);
            EventJezyk += new EventHandler(EventMethodJ);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        //obsluga jezyka
        public void OnEventL(bool frm)
        {
            if (EventLanguage != null)
                EventLanguage(frm, new EventArgs());
        }

        private void EventMethodL(object sender, EventArgs e)
        {
            richTextBox1.Text = "We promote reading and Polish literature.\nWe invite you to download the free ebook\nwritten by one of the Polish authors!\n\nScan the QR code to download the book (the book is in Polish):";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
            label1.Text = "Automatic closing of\nthe window will occur in:";
        }

        public void OnEventJ(bool frm)
        {
            if (EventJezyk != null)
                EventJezyk(frm, new EventArgs());
        }

        private void EventMethodJ(object sender, EventArgs e)
        {
            richTextBox1.Text = "Promujemy czytelnictwo i polską literaturę.\n\nZapraszamy do pobrania darmowego ebooka jednego\nz polskich autorów!\n\nZeskanuj kod QR w celu pobrania książki:";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
            label1.Text = "Automatyczne zamknięcie\nokna nastąpi za:";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormTimer--;
            label2.Text = FormTimer.ToString() + "s";
            if (FormTimer < 0)
            {
                Close();
            }
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

    }
}
