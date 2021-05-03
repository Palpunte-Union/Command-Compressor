using System;
using System.Windows.Forms;

namespace Command_Compressor
{
    public partial class AddPage : Form
    {

        public string ReturnValue = "";

        private string[] strings;
        public AddPage(string[] strs)
        {
            InitializeComponent();
            strings = strs;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                foreach (string str in strings)
                {
                    if (str == textBox.Text)
                    {
                        MessageBox.Show("すでに存在します。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                ReturnValue = textBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("値を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox.Text != "")
                {
                    foreach (string str in strings)
                    {
                        if (str == textBox.Text)
                        {
                            MessageBox.Show("すでに存在します。",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                    ReturnValue = textBox.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("値を入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
