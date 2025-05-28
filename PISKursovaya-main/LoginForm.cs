using Microsoft.VisualBasic;
using PISKursovaya.Logic;
using PISKursovaya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISKursovaya
{
    public partial class LoginForm : Form
    {
        private BuisnessLogic buisnessLogic = new BuisnessLogic(new DataBaseAccess());
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) && string.IsNullOrWhiteSpace(textBoxLogin.Text)
                && string.IsNullOrEmpty(textBoxPassword.Text) && string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Данные не введены.");
                return;
            }

            bool isAuthorized = buisnessLogic.TryAuthorizeAccess(textBoxLogin.Text, textBoxPassword.Text, out User user);
            if (!isAuthorized) { MessageBox.Show("Авторизация не пройдена."); return; }

            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;

            if (user.need_change_password)
            {
                bool passwordChanged = false;
                while (!passwordChanged)
                {
                    string password = Interaction.InputBox("Требуется сменить пароль. Введите новый пароль.");
                    if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                    {
                        user.password = password;
                        user.need_change_password = false;
                        buisnessLogic.SaveChangedUser(user);
                        passwordChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Пароль введен некорректно.");
                    }
                }
            }

            if (user.role == Role.Supplier)
            {
                SubForm.OpenSubForm(this, new SupplierForm(buisnessLogic, user.user_id));
            }
            else if (user.role == Role.Firm)
            {
                SubForm.OpenSubForm(this, new FirmForm(buisnessLogic, user.user_id));
            }
        }
    }
}
