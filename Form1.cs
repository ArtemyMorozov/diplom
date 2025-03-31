using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace diplom
{
    public partial class Form1 : Form
    {
        private const string YANDEX_API_URL = "https://api.iot.yandex.net/v1.0/user/info";
        private const string ACCESS_TOKEN = "y0__xCawdl6GIbJNiDIua7YEiiF4wsfD-QrgI5Cft8QKqbaw6O8"; // Вставь сюда свой токен
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void con1_Click(object sender, EventArgs e)
        {
            string response = await GetDevicesFromYandex();
            textBox1.Text = response; // Вывод списка устройств
        }
        private async Task<string> GetDevicesFromYandex()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + ACCESS_TOKEN);
                client.DefaultRequestHeaders.Add("User-Agent", "MySmartHomeApp/1.0"); // Добавляем заголовок

                HttpResponseMessage response = await client.GetAsync(YANDEX_API_URL);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return "Ошибка: " + response.StatusCode;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
