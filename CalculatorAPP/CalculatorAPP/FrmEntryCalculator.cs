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
    public partial class FrmEntryCalculator : Form
    {
        public delegate void CalculatorEventHandler(int operasi, int a, int b);

        public event CalculatorEventHandler OnHitung;


        public FrmEntryCalculator()
        {
            InitializeComponent();
            cbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmEntryCalculator_Load(object sender, EventArgs e)
        {

        }

       
        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(textBoxA.Text);
            int NilaiB = int.Parse(textBoxB.Text);

            if (cbOperasi.SelectedIndex == 0)
            {
                OnHitung(0, NilaiA, NilaiB);
            }
            else if (cbOperasi.SelectedIndex == 1)
            {
                OnHitung(1, NilaiA, NilaiB);
            }
            else if (cbOperasi.SelectedIndex == 2)
            {
                OnHitung(2, NilaiA, NilaiB);
            }
            else
            {
                OnHitung(3, NilaiA, NilaiB);
            }

        }
    }
}
