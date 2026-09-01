using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Froms
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void CloseFormDelegate();
        public CloseFormDelegate closeForm;
        private int _PersonId =-1;
        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            _PersonId = PersonID;
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            if (_PersonId != -1)
            {
                lblTitle.Text = "Update Person";
                lblPersonId.Text = _PersonId.ToString();
                cntrlAddEditPerson1.LoadPersonData(_PersonId);
            }
        }
        private void cntrlAddEditPerson1_Load(object sender, EventArgs e)
        {
            cntrlAddEditPerson1.CloseForm += CloseForm;
        }
        private void CloseForm()
        {
            this.Close();
        }
    }
}
