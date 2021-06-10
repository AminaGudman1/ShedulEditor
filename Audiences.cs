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
    public partial class Audiences : Form
    {
        public string number;
        public Audiences()
        {
            InitializeComponent();
        }

        private void Audiences_Load(object sender, EventArgs e)
        {
            dataGridEditor.RowTemplate.Height = 50;

            List<Cabinets> sb = new List<Cabinets>();
            using (StreamReader sr = new StreamReader("data.json"))
            {
                sb = JsonConvert.DeserializeObject<List<Cabinets>>(sr.ReadToEnd());
            }
            foreach (var item in sb)
                dataGridEditor.Rows.Add(item.Number, item.AComputer, item.Board,
                    item.CountOfSeats, item.CountOfTables, item.Projector);
        }

        private void dataGridEditor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            number = dataGridEditor.Rows[e.RowIndex].Cells[0]
                .Value.ToString();
            Close();
        }
    }
}
            