using AspNetIdentity.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetIdentity.Client
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();

            lstWeatherForecast.View = View.Details;
            lstWeatherForecast.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lstWeatherForecast.Columns.Add("Summary", 150, HorizontalAlignment.Left);
            lstWeatherForecast.Columns.Add("Temp (C)", 80, HorizontalAlignment.Left);
            lstWeatherForecast.Columns.Add("Temp (F)", 80, HorizontalAlignment.Left);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var model = new LoginViewModel
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            var jsonData = JsonConvert.SerializeObject(model);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //Send request
            var response = await client.PostAsync("https://localhost:7101/api/auth/login", content);

            var responseBody = await response.Content.ReadAsStringAsync();

            var responseObject = JsonConvert.DeserializeObject<UserManagerResponse>(responseBody);

            if (responseObject.IsSuccess)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string accessToken = responseObject.Message;

                //If authorized, gets access to protected resource
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var response1 = await client.GetAsync("https://localhost:7101/WeatherForecast");
                var responseBody1 = await response1.Content.ReadAsStringAsync();
                var weatherForecasts = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(responseBody1);

                foreach (var forecast in weatherForecasts)
                {
                    ListViewItem item = new ListViewItem(forecast.Date.ToString());
                    item.SubItems.Add(forecast.Summary ?? "");
                    item.SubItems.Add(forecast.TemperatureC.ToString());
                    item.SubItems.Add(forecast.TemperatureF.ToString());
                    lstWeatherForecast.Items.Add(item);
                }

            }
            else
            {
                //if (responseObject.Errors != null && responseObject.Errors.Any())
                //{
                //    MessageBox.Show(responseObject.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                MessageBox.Show(responseObject.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
                form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private async void btnForgetPw_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var model = new ForgotPasswordViewModel
            {
                Email = txtPwEmail.Text,
            };

            var jsonData = JsonConvert.SerializeObject(model);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //Send request
            var response = await client.PostAsync("https://localhost:7101/api/auth/ForgetPassword", content);

            var responseBody = await response.Content.ReadAsStringAsync();

            var responseObject = JsonConvert.DeserializeObject<UserManagerResponse>(responseBody);
        }
    }
}
