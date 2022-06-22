using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Service;

namespace TurnpikeGate.View.AdministratorViews
{
    public partial class UsersDisplayForm : Form
    {
        private readonly IUserService _userService;

        public UsersDisplayForm()
        {
            InitializeComponent();
            _userService = Globals.Container.Resolve<IUserService>();
        }

        private void UsersDisplayForm_Load(object sender, EventArgs e)
        {
            var users = _userService.GetAll();
            users.ForEach(u =>
            {
                int index = dgvUsers.Rows.Add();
                dgvUsers.Rows[index].Cells["name"].Value = u.Name;
                dgvUsers.Rows[index].Cells["lastName"].Value = u.LastName;
                dgvUsers.Rows[index].Cells["email"].Value = u.Email;
                dgvUsers.Rows[index].Cells["phoneNumber"].Value = u.PhoneNumber;
                dgvUsers.Rows[index].Cells["JMBG"].Value = u.JMBG;
                dgvUsers.Rows[index].Cells["salary"].Value = u.Salary;
                dgvUsers.Rows[index].Cells["isActive"].Value = u.IsActive;
            });
        }
    }
}
