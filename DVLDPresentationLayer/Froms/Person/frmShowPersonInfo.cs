using DVLDPresentationLayer.User_Controls;
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
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonId;

        public frmShowPersonInfo(int personId)
        {
            _PersonId = personId;
            InitializeComponent();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            cntrlShowPersonInfo1.LoadPersonInfo(_PersonId);
        }
    }
}
