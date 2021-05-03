using System;
using System.Windows.Forms;

namespace Command_Compressor
{
    public partial class OutputForm : Form
    {
        public OutputForm(string s)
        {
            InitializeComponent();
            textBox.Text = s;
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            this.Text = "出力";
            saveFileDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                SaveText(saveFileDialog.FileName);
            }
        }

        private void SaveText(string path)
        {
            System.IO.File.WriteAllText(path, textBox.Text, System.Text.Encoding.GetEncoding("SHIFT_JIS"));
        }
    }
}
