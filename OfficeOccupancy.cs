using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheduleEditor_Amina
{
    public partial class SheduleEditor : Form
    {
        private List<Group> listGroup = new List<Group>();
        public SheduleEditor()
        {
            InitializeComponent();
        }

        private void DataGreadSheduleVisible(DataGridView data)
        {
            data.RowTemplate.Height = 50;
            data.Rows.Add();
            data.Rows.Add();
            data.Rows.Add();
            data.Rows.Add();

            data.Rows[0].HeaderCell.Value = "1";
            data.Rows[1].HeaderCell.Value = "2";
            data.Rows[2].HeaderCell.Value = "3";
            data.Rows[3].HeaderCell.Value = "4";
        }

        private void RecordingTheSourceData()
        {
            LoadFromFile();
            foreach (var item in listGroup)
            {
                
            }
        }

        public void SaveToFile()
        {
            var agJson = JsonConvert.SerializeObject(listGroup);
            using (StreamWriter sw = new StreamWriter("listGroup.json"))
                sw.WriteLine(agJson);
        }

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader("listGroup.json"))
            {
                listGroup = JsonConvert.DeserializeObject<List<Group>>(sr.ReadToEnd());
            }
        }

        private void SheduleEditor_Load(object sender, EventArgs e)
        {
            DataGreadSheduleVisible(dataGridShedule11);
            DataGreadSheduleVisible(dataGridShedule12);
            DataGreadSheduleVisible(dataGridShedule13);
            DataGreadSheduleVisible(dataGridShedule14);
            DataGreadSheduleVisible(dataGridShedule21);
            DataGreadSheduleVisible(dataGridShedule22);
            DataGreadSheduleVisible(dataGridShedule23);
            DataGreadSheduleVisible(dataGridShedule24);
            DataGreadSheduleVisible(dataGridShedule31);
            DataGreadSheduleVisible(dataGridShedule32);
            DataGreadSheduleVisible(dataGridShedule33);
            DataGreadSheduleVisible(dataGridShedule34);
            DataGreadSheduleVisible(dataGridShedule41);
            DataGreadSheduleVisible(dataGridShedule42);
            DataGreadSheduleVisible(dataGridShedule43);
            DataGreadSheduleVisible(dataGridShedule44);
        }
        
        private void DataGridShedule_ToWrite(DataGridView data, DataGridViewCellEventArgs e)
        {
           
            try
            {
                Audiences s = new Audiences();
                s.ShowDialog();
                var tabs = tabControlGroup.TabPages;
            foreach (TabPage tab in tabs)
                if (tab!=tabControlGroup.SelectedTab)
                {
                        DataGridView dg = (DataGridView)tab.Controls[0];
                        string cellValue= (string)dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (cellValue==s.number&&cellValue!=null)
                        {
                            dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor =
                                System.Drawing.Color.Red;
                            data.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor =
                                System.Drawing.Color.Red;
                        }
                }
                data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.number;

            }
            catch { }
             Group gr = new Group(Convert.ToInt32(tabControlGroup.SelectedTab.Text), data.Columns[e.ColumnIndex].HeaderText.ToString(),
              Convert.ToInt32(data.Rows[e.RowIndex].HeaderCell.Value), Convert.ToInt32(data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
            listGroup.Add(gr);
        }

        private void dataGridShedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule11, e);
        }

        private void dataGridShedule12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule12, e);
        }

        private void dataGridShedule13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule13, e);
        }

        private void dataGridShedule14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule14, e);
        }

        private void dataGridShedule21_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule21, e);
        }

        private void dataGridShedule22_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule22, e);
        }

        private void dataGridShedule23_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule23, e);
        }

        private void dataGridShedule24_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule24, e);
        }

        private void dataGridShedule31_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule31, e);
        }

        private void dataGridShedule32_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule32, e);
        }

        private void dataGridShedule33_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule33, e);
        }

        private void dataGridShedule34_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule34, e);
        }

        private void dataGridShedule41_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule41, e);
        }

        private void dataGridShedule42_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule42, e);
        }

        private void dataGridShedule43_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule43, e);
        }

        private void dataGridShedule44_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridShedule_ToWrite(dataGridShedule44, e);
        }

        private void SheduleEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
    }
}
