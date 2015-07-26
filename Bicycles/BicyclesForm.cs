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
    }
}
