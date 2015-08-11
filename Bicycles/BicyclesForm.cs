using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycles
{
    public partial class bicyclesForm : Form
    {
        BicycleContext _context;

        public bicyclesForm()
        {
            InitializeComponent();
        }

        private void bicyclesForm_Load(object sender, EventArgs e)
        {
            _context = new BicycleContext();
            _context.BicycleTypes.Load();
            _context.AmortizationTypes.Load();
            _context.Bicycles.Load();

            bicycleTypeBindingSource.DataSource = _context.BicycleTypes.Local.ToBindingList();
            amortizationTypeBindingSource.DataSource = _context.AmortizationTypes.Local.ToBindingList();
            bicycleBindingSource.DataSource = _context.Bicycles.Local.ToBindingList();
        }

        private void bicycleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            _context.SaveChanges();
            bicycleDataGridView.Refresh();
        }

        private void bicyclesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void exportToOOButton_Click(object sender, EventArgs e)
        {
            var bicyclesTable = new object[bicycleDataGridView.Rows.Count];
            int i = 0;
            foreach (DataGridViewRow row in bicycleDataGridView.Rows)
            {
                bicyclesTable[i] = new string[] {
                    Convert.ToString(row.Cells[1].Value),
                    Convert.ToString(row.Cells[2].Value),
                    Convert.ToString(row.Cells[3].FormattedValue),
                    Convert.ToString(row.Cells[4].FormattedValue)};
                i++;
            }

            var ooExport = new OpenOffice();
            ooExport.ExportToWriter(
                AppDomain.CurrentDomain.BaseDirectory + "Bicycles.ott",
                bicyclesTable);
        }
    }
}
