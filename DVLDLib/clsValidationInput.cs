using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDLib
{
    public static class clsValidationInput
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);

                if (mail.Address != email)
                    return false;

                string[] hostParts = mail.Host.Split('.');
                return hostParts.Length >= 2 && hostParts[hostParts.Length - 1].Length >= 2;

            }
            catch
            {
                return false;
            }
        }
    }
}
