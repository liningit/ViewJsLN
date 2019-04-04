using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewJsLN
{
    public partial class SelectOpenItem : Form
    {
        public string SelItem { get; set; }
        public SelectOpenItem(List<string> lst)
        {
            InitializeComponent();
            foreach (var i in lst)
            {
                dgvItem.Rows.Add(i);
            }
        }

        private void SelectOpenItem_Load(object sender, EventArgs e)
        {

        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelItem = dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }
    }
}
