using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Command_Compressor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ImageRun.DataPropertyName = "ImageRun";
            ImageEnd.DataPropertyName = "ImageEnd";
        }

        [STAThread]
        static public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        int PageNum = 0;
        TabPage CurrentPage;

        string defaultCommand = "summon minecraft:falling_block ~ ~2 ~ {Motion:[0.0, 0.1, 0.0],BlockState:{Name:\"minecraft:stone\",Time:1,DropItem:false},Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:stone\"},Time:1,DropItem:false,Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:stone\"},Time:1,DropItem:false%Command%}]}]}]}]}]}]}";
        string tempCommand = ",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:%CommandBlockType%command_block\",Properties:{facing:up}},Time:1,DropItem:false,TileEntityData:{auto:%Auto%,Command:\"%Command%\"}%NextCommand%}]}]}]";

        private void Form_Load(object sender, EventArgs e)
        {
            Text = "Command Compressor";
            dataGridViewOnRun["ImageRun", 0].Value = Resource_texture.command_block_side;
            dataGridViewOnRun.AutoGenerateColumns = false;
            dataGridViewOnEnd["ImageEnd", 0].Value = Resource_texture.command_block_side;
            dataGridViewOnEnd.AutoGenerateColumns = false;
        }

        private void dataGridViewOnRun_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == 0)
            {
                dataGridViewOnRun["ImageRun", 0].Value = Resource_texture.command_block_side;
            }
            else
            {
                dataGridViewOnRun["ImageRun", index].Value = Resource_texture.chain_command_block_side;
            }
        }

        private void ButtonAddPage_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            string[] strs = new string[tabControl.TabPages.Count];
            int i = 0;
            foreach (TabPage tabPage in tabControlSub.TabPages)
            {
                strs[i] = tabPage.Text;
            }
            string s = ShowAddPageForm(strs);
            if (s != "")
            {
                TabPage tabPage = new TabPage
                {
                    Name = "Page" + PageNum.ToString(),
                    Text = s
                };
                DataGridForCommand dataGrid = new DataGridForCommand();
                dataGrid.Dock = DockStyle.Fill;
                tabPage.Controls.Add(dataGrid);
                if (tabControlSub.TabPages.Count == 0)
                {
                    CurrentPage = tabPage;
                }
                tabControlSub.Controls.Add(tabPage);
                PageNum++;
            }
            ResumeLayout();
        }

        private void dataGridViewOnRun_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewOnRun["ImageRun", e.RowIndex].Value = Resource_texture.chain_command_block_side;
        }

        private void dataGridViewOnEnd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == 0)
            {
                dataGridViewOnEnd["ImageEnd", 0].Value = Resource_texture.command_block_side;
            }
            else
            {
                dataGridViewOnEnd["ImageEnd", index].Value = Resource_texture.chain_command_block_side;
            }
        }

        private void dataGridViewOnEnd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewOnEnd["ImageEnd", e.RowIndex].Value = Resource_texture.chain_command_block_side;
        }

        static public string ShowAddPageForm(string[] s)
        {

            AddPage f = new AddPage(s);
            f.ShowDialog();
            string receiveText = f.ReturnValue;
            f.Dispose();

            return receiveText;
        }

        private void tabControlSub_Selected(object sender, TabControlEventArgs e)
        {
            CurrentPage = e.TabPage;
        }

        private void ButtonDeletePage_Click(object sender, EventArgs e)
        {
            tabControlSub.Controls.Remove(CurrentPage);
        }

        private void menuItemExport_Click(object sender, EventArgs e)
        {
            dataGridViewOnRun.EndEdit();
            dataGridViewOnEnd.EndEdit();
            List<DataGridView> AutoRuns = new List<DataGridView>();
            foreach (TabPage page in tabControlSub.TabPages)
            {
                if (page.Controls[0] is DataGridForCommand)
                {
                    AutoRuns.Add(((DataGridForCommand)page.Controls[0]).GetData());
                }
            }
            string temp;
            if ((string)dataGridViewOnRun.Rows[0].Cells[1].Value != "" && (string)dataGridViewOnRun.Rows[0].Cells[1].Value != null)
            {
                temp = defaultCommand.Replace("%Command%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "0b").Replace("%Command%", ((string)dataGridViewOnRun.Rows[0].Cells[1].Value).Replace("\"", "\\\"")));
            }
            else
            {
                temp = defaultCommand.Replace("%Command%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "0b").Replace("%Command%", "tellraw @a[tag=DEBUG_A] \\\"It's Empty!\\\""));
            }
            int k = 2;
            for (int i = 1; i < dataGridViewOnRun.RowCount; i++)
            {
                if ((string)dataGridViewOnRun.Rows[i].Cells[1].Value != "" && (string)dataGridViewOnRun.Rows[i].Cells[1].Value != null)
                {
                    temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(2)).Replace("%Auto%", "1b").Replace("%Command%", ((string)dataGridViewOnRun.Rows[i].Cells[1].Value).Replace("\"", "\\\"")));
                    k++;
                }
            }
            temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(2)).Replace("%Auto%", "1b").Replace("%Command%", "fill ~ ~-" + k + " ~ ~ ~1 ~ minecraft:air"));
            k++;
            temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "1b").Replace("%Command%", "setblock ~ ~-" + k + " ~ minecraft:redstone_block"));

            temp = temp.Replace("%NextCommand%", ",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\"%NextCommand%}]}]}]}]");
            temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "0b").Replace("%Command%", "%LastCommand%"));

            k = 0;
            foreach (DataGridView view in AutoRuns)
            {
                if ((string)view.Rows[0].Cells[1].Value != "" && (string)view.Rows[0].Cells[1].Value != null)
                {
                    temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(1)).Replace("%Auto%", "1b").Replace("%Command%", ((string)view.Rows[0].Cells[1].Value).Replace("\"", "\\\"")));
                }
                else
                {
                    temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(1)).Replace("%Auto%", "1b").Replace("%Command%", "tellraw @a[tag=DEBUG_A] \\\"It's Empty!\\\""));
                }
                k++;
                for (int i = 1; i < view.RowCount; i++)
                {
                    if ((string)view.Rows[i].Cells[1].Value != "" && (string)view.Rows[i].Cells[1].Value != null)
                    {
                        temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(2)).Replace("%Auto%", "1b").Replace("%Command%", ((string)view.Rows[i].Cells[1].Value).Replace("\"", "\\\"")));
                        k++;
                    }
                }
            }

            temp = temp.Replace("%NextCommand%", ",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:stone\",Properties:{facing:up}},Time:1,DropItem:false%NextCommand%}]}]}]");
            k++;
            temp = temp.Replace("%LastCommand%", "setblock ~ ~" + k.ToString() + " ~ minecraft:redstone_block");
            if ((string)dataGridViewOnEnd.Rows[0].Cells[1].Value != "" && (string)dataGridViewOnEnd.Rows[0].Cells[1].Value != null)
            {
                temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "0b").Replace("%Command%", ((string)dataGridViewOnEnd.Rows[0].Cells[1].Value).Replace("\"", "\\\"")));
            }
            else
            {
                temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(0)).Replace("%Auto%", "0b").Replace("%Command%", "tellraw @a[tag=DEBUG_A] \\\"It's Empty!\\\""));
            }
            for (int i = 1; i < dataGridViewOnEnd.RowCount; i++)
            {
                if ((string)dataGridViewOnEnd.Rows[i].Cells[1].Value != "" && (string)dataGridViewOnEnd.Rows[i].Cells[1].Value != null)
                {
                    temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(2)).Replace("%Auto%", "1b").Replace("%Command%", ((string)dataGridViewOnEnd.Rows[i].Cells[1].Value).Replace("\"", "\\\"")));
                    k++;
                }
            }
            k += 3;
            temp = temp.Replace("%NextCommand%", tempCommand.Replace("%CommandBlockType%", GetName(2)).Replace("%Auto%", "1b").Replace("%Command%", "fill ~ ~ ~ ~ ~-" + k.ToString() + " ~ minecraft:air"));
            temp = temp.Replace("%NextCommand%", "");
            ShowExportForm(temp);
        }
        static string GetName(int type)
        {
            string[] CommandBlockNames = { "", "repeating_", "chain_" };
            return CommandBlockNames[type];
        }

        static public void ShowExportForm(string s)
        {

            OutputForm f = new OutputForm(s);
            f.ShowDialog();
            f.Dispose();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}