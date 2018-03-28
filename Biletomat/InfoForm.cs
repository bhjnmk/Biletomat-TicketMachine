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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        static InfoForm newInfoForm;
        int FormTimer;
        Timer msgTimer = new Timer();

        private void InfoForm_Load(object sender, EventArgs e)
        {
            FormTimer = 30;
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(timer_tick);
            MainForm.OnEventT2(true);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            FormTimer--;

            if (FormTimer < 0)
            {
                newInfoForm.Close();
            }
        }

        public static void ShowBox(string txtMessage, string txtTitle)
        {
            newInfoForm = new InfoForm();
            newInfoForm.richTextBox1.Text = txtMessage;
            newInfoForm.Text = txtTitle;
            newInfoForm.richTextBox1.SelectAll();
            newInfoForm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            newInfoForm.richTextBox1.DeselectAll();
            newInfoForm.ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            newInfoForm.Close();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            msgTimer.Stop();
            MainForm.OnEventT(true);
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
    }
}
