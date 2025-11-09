using System.Configuration;

namespace Lab1.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(
                Resource1.ResHello,
                ConfigurationManager.AppSettings.Get("Name") ?? "Студент"
                ));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(string.Format(
               Resource1.ResBye,
               ConfigurationManager.AppSettings.Get("Name") ?? "Студент"
               ));
        }
    }
}
