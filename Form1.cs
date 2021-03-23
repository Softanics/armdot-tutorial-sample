using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace armdot_tutorial_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [ArmDot.Client.VirtualizeCode]
        private void buttonCheckPassword_Click(object sender, EventArgs e)
        {
            byte[] hash = (new SHA256Managed()).ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));

            if (hash[0] == 81 && hash[1] == 96 && hash[2] == 9 && hash[3] == 150 &&
                hash[4] == 45 && hash[5] == 146 && hash[6] == 51 && hash[7] == 201 &&
                hash[8] == 238 && hash[9] == 22 && hash[10] == 103 && hash[11] == 233 &&
                hash[12] == 209 && hash[13] == 135 && hash[14] == 107 && hash[15] == 39 &&
                hash[16] == 228 && hash[17] == 171 && hash[18] == 22 && hash[19] == 78 &&
                hash[20] == 218 && hash[21] == 213 && hash[22] == 11 && hash[23] == 131 &&
                hash[24] == 71 && hash[25] == 17 && hash[26] == 241 && hash[27] == 180 &&
                hash[28] == 118 && hash[29] == 9 && hash[30] == 163 && hash[31] == 249)
            {
                MessageBox.Show("The password is correct");
            }
            else
            {
                MessageBox.Show("The password is wrong");
            }
        }

        [ArmDot.Client.VirtualizeCode]
        private void buttonCheckLicense_Click(object sender, EventArgs e)
        {
            ArmDot.Client.Api.PutKey(textBoxPassword.Text);

            string state;
            string userName = null;

            switch (ArmDot.Client.Api.GetLicenseState())
            {
                case ArmDot.Client.Api.LicenseKeyState.Valid:
                    {
                        state = "valid";
                        userName = ArmDot.Client.Api.GetUserName();
                        break;
                    }
                case ArmDot.Client.Api.LicenseKeyState.Blocked:
                    {
                        state = "blocked";
                        break;
                    }
                case ArmDot.Client.Api.LicenseKeyState.Expired:
                    {
                        state = "expired";
                        break;
                    }
                case ArmDot.Client.Api.LicenseKeyState.MaximumBuildDateExpired:
                    {
                        state = "maximum build date expired";
                        break;
                    }
                case ArmDot.Client.Api.LicenseKeyState.BadHardwareId:
                    {
                        state = "bad hardware id";
                        break;
                    }
                case ArmDot.Client.Api.LicenseKeyState.Invalid:
                default:
                    {
                        state = "invalid";
                        break;
                    }
            }

            MessageBox.Show($"The key state is {state}, user name is {userName ?? "<unknown>"}");
        }
    }
}
