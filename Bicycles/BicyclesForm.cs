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
            //using (var db = new BicycleContext())
            //{
            //    var t = (from bt in db.BicycleTypes
            //             where bt.Name == "Дорожный"
            //             select bt).FirstOrDefault();
            //    db.BicycleTypes.Remove(t);
            //    db.BicycleTypes.Add(new BicycleType() { Name = "Шоссейный" });
            //db.BicycleTypes.Add(new BicycleType() { Name = "Городской" });
            //db.BicycleTypes.Add(new BicycleType() { Name = "Круизер" });
            //db.BicycleTypes.Add(new BicycleType() { Name = "Горный" });
            //db.BicycleTypes.Add(new BicycleType() { Name = "Дорожный" });
            //db.BicycleTypes.Add(new BicycleType() { Name = "Туринг" });

            //db.AmortizationTypes.Add(new AmortizationType() { Name = "Двухподвес" });
            //db.AmortizationTypes.Add(new AmortizationType() { Name = "Хардтейл" });
            //db.AmortizationTypes.Add(new AmortizationType() { Name = "Ригид" });

            //    db.SaveChanges();
            //}

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
