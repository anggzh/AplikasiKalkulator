using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAPP
{
    public partial class FrmHasilPerhitungan : Form
    {
        private void FrmHasil_OnHitung(int operasi, int a, int b)
        {
            var hitung = new Calculator();

            switch (operasi)
            {
                case 0:
                    lvwCalculator.Items.Add(string.Format("Hasil penjumlahan : {0} + {1} = {2}", a, b, hitung.Penjumlahan(a, b)));
                    break;
                case 1:
                    lvwCalculator.Items.Add(string.Format("Hasil pengurangan : {0} - {1} = {2}", a, b, hitung.Pengurangan(a, b)));
                    break;
                case 2:
                    lvwCalculator.Items.Add(string.Format("Hasil perkalian : {0} * {1} = {2}", a, b, hitung.Perkalian(a, b)));
                    break;
                case 3:
                    lvwCalculator.Items.Add(string.Format("Hasil pembagian : {0} / {1} = {2}", a, b, hitung.Pembagian(a, b)));
                    break;

            }

        }
       
        public FrmHasilPerhitungan()
        {
            InitializeComponent();
            lvwCalculator.View = View.List;

        }

        

        private void lvwCalculator_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmEntryCalculator form = new FrmEntryCalculator();

            form.OnHitung += FrmHasil_OnHitung;
            form.ShowDialog();
        }
    }
}
