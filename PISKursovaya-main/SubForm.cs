using System;
using System.Windows.Forms;

namespace PISKursovaya
{
    public class SubForm : Form
    {
        public SubForm() => FormClosed += ExitApplication;
        private void ExitApplication(object sender, EventArgs e) => Application.Exit();

        public void CloseSubForm()
        {
            FormClosed -= ExitApplication;
            this.Owner.Visible = true;
            Owner.Location = Location;
            Close();
        }

        public static void OpenSubForm(Form MainForm, SubForm SubFormToOpen)
        {
            MainForm.Hide();
            SubFormToOpen.Owner = MainForm;
            SubFormToOpen.StartPosition = FormStartPosition.Manual;
            SubFormToOpen.Location = MainForm.Location;
            SubFormToOpen.ShowDialog();
        }
    }
}
