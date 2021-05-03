using System.Windows.Forms;

namespace Command_Compressor
{
    public partial class DataGridForCommand : UserControl
    {
        public DataGridForCommand()
        {
            InitializeComponent();
            dataGridView["ImageCommandBlock", 0].Value = Resource_texture.repeating_command_block_side;
            dataGridView.AutoGenerateColumns = false;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView["ImageCommandBlock", e.RowIndex].Value = Resource_texture.chain_command_block_side;
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == 0)
            {
                dataGridView["ImageCommandBlock", 0].Value = Resource_texture.repeating_command_block_side;
            }
            else
            {
                dataGridView["ImageCommandBlock", index].Value = Resource_texture.chain_command_block_side;
            }
        }

        public DataGridView GetData()
        {
            return this.dataGridView;
        }
    }
}
