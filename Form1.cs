using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Anketa : Form
    {
        RegisForm form = new RegisForm();
        public Anketa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbx_FirstName_TextChanged(object sender, EventArgs e)
        {
            form.FirstName = tbx_FirstName.Text;
        }

        private void tbx_LastName_TextChanged(object sender, EventArgs e)
        {
            form.LastName = tbx_LastName.Text;
        }

        private void tbx_Company_TextChanged(object sender, EventArgs e)
        {
            form.Company = tbx_Company.Text;
        }

        private void tbx_Email_TextChanged(object sender, EventArgs e)
        {
            form.Email = tbx_Email.Text;
        }

        private void dtp_Calendar_ValueChanged(object sender, EventArgs e)
        {
            form.DateOfBirth = dtp_Calendar.Value;
        }

        private void tbx_Country_TextChanged(object sender, EventArgs e)
        {
            form.Country = tbx_Country.Text;
        }

        private void tbx_LiveAddress_TextChanged(object sender, EventArgs e)
        {
            form.LiveAddress = tbx_LiveAddress.Text;
        }

        private void tbx_City_TextChanged(object sender, EventArgs e)
        {
            form.City = tbx_City.Text;
        }

        private void tbx_WorkAddress_TextChanged(object sender, EventArgs e)
        {
            form.WorkAddress = tbx_WorkAddress.Text;
        }

        private void Languages(object sender, EventArgs e)
        {
            if(sender is CheckBox cbx)
            {
                if (form.Languages == null)
                {
                    form.Languages = new string[1];
                    form.Languages[0] = cbx.Text;
                }
                else
                {
                    Array.Resize(ref form.Languages, form.Languages.Length + 1);
                    form.Languages[form.Languages.Length - 1] = cbx.Text;
                }
            }
        }

        private void ProgrammingLanguages(object sender, EventArgs e)
        {
            if (sender is CheckBox cbx)
            {
                if (form.ProgrammingLanguages == null)
                {
                    form.ProgrammingLanguages = new string[1];
                    form.ProgrammingLanguages[0] = cbx.Text;
                }
                else
                {
                    Array.Resize(ref form.ProgrammingLanguages, form.ProgrammingLanguages.Length + 1);
                    form.ProgrammingLanguages[form.ProgrammingLanguages.Length - 1] = cbx.Text;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("form.json", JsonConvert.SerializeObject(form, Newtonsoft.Json.Formatting.Indented));
        }

        private void cbx_Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Accept.Checked) btn_Save.Enabled = true;
            else btn_Save.Enabled = false;
        }
    }
}