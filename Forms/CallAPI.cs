using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestAPI.Shared;


namespace RestAPI.Forms
{
    public partial class CallAPI : Form
    {
        public CallAPI()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll();
            rtbInfo.Text = RestHelper.BeautifyJson(response);

        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Get(txtID.Text);
            rtbInfo.Text = RestHelper.BeautifyJson(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Post(txtName.Text, txtJob.Text);
            rtbInfo.Text = RestHelper.BeautifyJson(response);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Put(txtID.Text, txtName.Text, txtJob.Text);
            rtbInfo.Text = RestHelper.BeautifyJson(response);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var response = await Delete(txtID.Text);
            rtbInfo.Text = response;
        }

        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://reqres.in/api/users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(((int)res.StatusCode).ToString() + " - "+ res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }
    }
}
