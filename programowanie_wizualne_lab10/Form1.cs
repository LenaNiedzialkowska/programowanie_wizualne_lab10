using System.IO;
using System.Media;

namespace programowanie_wizualne_lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.List;
            listView1.Clear();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "Audio (*.cs,*.acc,*wma)|*.cs;*.mp3;*.wma|All Files (*.*)|*.*";
                DialogResult answer = file.ShowDialog();
                if (answer == DialogResult.OK)
                {
                    foreach (var item in file.FileNames)
                    {
                        listView1.Items.Add(file.SafeFileName);
                    }
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {

        }
    }
}