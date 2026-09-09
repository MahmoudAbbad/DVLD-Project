using DVLDLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDPresentationLayer.GlobalLibraries
{
    public static class clsValidationUi
    {
        public static bool IsValidInput(Control control, ErrorProvider WarningError, string errorMessage)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                WarningError.SetError(control, errorMessage);
                return false;
            }
            else
            {
                WarningError.SetError(control, "");
                return true;
            }
        }
    }
}