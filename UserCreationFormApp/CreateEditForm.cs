using UserCreationFormApp.Models;
using UserCreationFormApp.Repositories;

namespace UserCreationFormApp
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private int userId = 0;
        
        //this is off - not saving when editting
        public void EditUser(User user)
        {
            this.Text = "Edit User";
            this.lbTitle.Text = "Edit User";

            this.lbID.Text = "" + user.ID;
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbEmail.Text = user.Email;
            this.tbPhone.Text = user.Phone;
            this.tbAddress.Text = user.Address;

            this.userId = user.ID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new()
            {
                ID = this.userId,
                FirstName = this.tbFirstName.Text,
                LastName = this.tbLastName.Text,
                Email = this.tbEmail.Text,
                Phone = this.tbPhone.Text,
                Address = this.tbAddress.Text,
                //CreatedAt = DateTime.Now.ToString(),
            };

            var repo = new UserRepository();

            if (user.ID == 0) 
            {        
                repo.AddUser(user);
            }
            else
            {
                repo.UpdateUser(user);
            }

                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
