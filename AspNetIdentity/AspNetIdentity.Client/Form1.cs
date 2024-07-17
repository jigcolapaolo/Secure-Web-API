using AspNetIdentity.Shared.IdentityAuth;
using AspNetIdentity.Shared.IdentityAuth.Register;
using Newtonsoft.Json;
using System.Text;

namespace AspNetIdentity.Client
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var model = new RegisterViewModel
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text,
            };

            var jsonData = JsonConvert.SerializeObject(model);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //Send request
            var response = await client.PostAsync("https://localhost:7101/api/auth/register", content);

            var responseBody = await response.Content.ReadAsStringAsync();

            var responseObject = JsonConvert.DeserializeObject<UserManagerResponse>(responseBody);

            if (responseObject.IsSuccess)
            {
                MessageBox.Show("Your account has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (responseObject.Errors != null && responseObject.Errors.Any())
                {
                    MessageBox.Show(responseObject.Errors.FirstOrDefault(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An unknown error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
                form2 = new Form2();

            form2.Show();
            this.Hide();
        }
    }
}
