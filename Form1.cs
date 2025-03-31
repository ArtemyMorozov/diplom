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
using Newtonsoft.Json.Linq;



namespace diplom
{
    public partial class Form1 : Form
    {
        private const string YANDEX_API_URL = "https://api.iot.yandex.net/v1.0/user/info";
        private const string ACCESS_TOKEN = "y0__xCawdl6GJHJNiCp7bPYEhcU7bpUj-abymhBU1ClAyawB27l"; // Вставь сюда свой токен
        private DateTime startTime; // Время, когда была нажата кнопка
        private Timer timer; // Таймер для обновления секундомера

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Таймер обновляется каждую секунду
            timer.Tick += Timer_Tick; // Обработчик события таймера
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Название", 150);
            listView1.Columns.Add("Тип", 150);
            listView1.Columns.Add("Состояние", 100);
        }

        private async void con1_Click(object sender, EventArgs e)
        {
            // Сохраняем текущее время при нажатии на кнопку
            startTime = DateTime.Now;

            // Запускаем таймер
            timer.Start();

            // Очищаем TextBox перед запуском таймера
            textBox1.Clear();

            string jsonResponse = await GetDevicesFromYandex();
            listView1.Items.Clear(); // Очищаем перед новым запросом

            JObject data = JObject.Parse(jsonResponse);
            JArray devices = (JArray)data["devices"];

            // Добавляем устройства в ListView
            foreach (JObject device in devices)
            {
                string name = device["name"].ToString();
                string type = device["type"].ToString();
                string state = "Неизвестно"; // Значение по умолчанию

                if (device.TryGetValue("capabilities", out JToken capabilitiesToken) && capabilitiesToken is JArray capabilities)
                {
                    if (capabilities.Count == 0)
                    {
                        if (device["type"].ToString().Contains("smart_speaker"))
                        {
                            state = "Голосовой ассистент";
                        }
                    }
                    else
                    {
                        foreach (JObject capability in capabilities)
                        {
                            if (capability["type"].ToString() == "devices.capabilities.on_off" &&
                                capability.TryGetValue("state", out JToken stateToken) &&
                                stateToken["value"] != null)
                            {
                                state = stateToken["value"].ToString() == "true" ? "Включено" : "Выключено";
                                break;
                            }
                        }
                    }
                }

                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(type);
                item.SubItems.Add(state);
                listView1.Items.Add(item);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime; // Вычисляем разницу во времени

            // Форматируем время в ЧЧ:ММ:СС
            string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
                elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);

            textBox1.Text = formattedTime; // Выводим в TextBox
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
            timer.Stop();
            this.Close();
        }
    }
}
