using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Froms.Person.Controls
{
    public partial class cntrlShowPersonInfoWithFilter : UserControl
    {
        public cntrlShowPersonInfoWithFilter()
        {
            InitializeComponent();
            _LoadDefaultSettings();
        }

        private void _LoadDefaultSettings()
        {
            cbFilter.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.ShowDialog();

        }

        private void tbSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)//search by person id
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                cntrlShowPersonInfo1.LoadPersonInfoByPersonId(tbSearchValue.Text.Trim().Length > 0 ? Convert.ToInt32(tbSearchValue.Text.Trim()) : -1);
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                cntrlShowPersonInfo1.LoadPersonInfoByNationalNo(tbSearchValue.Text.Trim());
            }
        }
    }
}
