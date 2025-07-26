using System.Data;
using UserCreationFormApp.Repositories;

namespace UserCreationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadUsers();
        }

        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Full Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Date Added");

            var repo = new UserRepository();
            var users = repo.GetUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["ID"] = user.ID;
                row["Full Name"] = user.FirstName + " " + user.LastName;
                row["Email"] = user.Email;
                row["Phone"] = user.Phone;
                row["Address"] = user.Address;
                row["Date Added"] = user.CreatedAt;

                dataTable.Rows.Add(row);
            }

            this.userTable.DataSource = dataTable;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();
            if (createEditForm.ShowDialog() == DialogResult.OK)
            {
                // Update the list of Users
                ReadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var value = this.userTable.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0) return;

            int userId = int.Parse(value);

            var repo = new UserRepository();
            var user = repo.GetUser(userId);

            if (user == null) return;

            CreateEditForm form = new();
            form.EditUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // update the list of Users
                ReadUsers();
            }
        }
    }
}
