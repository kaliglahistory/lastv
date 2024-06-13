using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.NetworkInformation;
using System.Net.WebSockets;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using _2;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace WinFormsApp1
{

    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //user tom = new user("276.234.121.25");
            //string json = JsonSerializer.Serialize(tom);
            //Console.WriteLine(json);
            //user? restoredPerson = JsonSerializer.Deserialize<user>(json);
            //Console.WriteLine(restoredPerson?.ip); // Tom

            string IP = textBox3.Text;
            string tab = textBox2.Text;


            // чтение данных
            // using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            // {
            //    user? person = await JsonSerializer.DeserializeAsync<user>(fs);
            //     Console.WriteLine($"Name: {person?.ip} ");
            // }



            // Работа с XML
            // string Path = @"C:\Users\user\source\repos\dip\DATA.TXT";
            // Random random = new Random();
            // int key = random.Next(0, 100000);
            // // FileInfo file = new FileInfo(Path);
            // string kayin = Convert.ToString(key);
            //// File.WriteAllText(Path, kayin);
            // XmlDocument DOX = new XmlDocument();
            // DOX.Load("C:\\Users\\Nick\\Desktop\\dip2.0\\WinFormsApp1\\XMLFile1.xml");
            // XmlElement xRoot = DOX.DocumentElement;
            // XmlElement kays = DOX.CreateElement("data");
            // XmlElement ipElem = DOX.CreateElement("ip");
            // XmlText SAD = DOX.CreateTextNode(kayin);
            // kays.AppendChild(SAD);
            // xRoot.AppendChild(kays);
            // DOX.Save("XMLFile1.xml");
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(textBox1.Text);
            var tcpListener = new TcpListener(IPAddress.Any, port);
            var words = new Dictionary<string, string>();
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            try
            {
                tcpListener.Start();    // запускаем сервер
                MessageBox.Show($"Ваш ip и порт  {localIPs[1]}:{port} ");
                Console.WriteLine("Сервер запущен. Ожидание подключений... ");

                while (true)
                {
                    // получаем подключение в виде TcpClient
                    using var tcpClient = await tcpListener.AcceptTcpClientAsync();
                    // получаем объект NetworkStream для взаимодействия с клиентом
                    var stream = tcpClient.GetStream();
                    // буфер для входящих данных
                    var response = new List<byte>();
                    int bytesRead = 10;
                    while (true)
                    {
                        // считываем данные до конечного символа
                        while ((bytesRead = stream.ReadByte()) != '\n')
                        {
                            // добавляем в буфер
                            response.Add((byte)bytesRead);
                            await Console.Out.WriteLineAsync(Convert.ToString(response));
                        }
                        var word = Encoding.UTF8.GetString(response.ToArray());

                        // если прислан маркер окончания взаимодействия,
                        // выходим из цикла и завершаем взаимодействие с клиентом
                        if (word == "END") break;

                        Console.WriteLine($"Запрошен перевод слова {word}");
                        // находим слово в словаре и отправляем обратно клиенту
                        if (!words.TryGetValue(word, out var itog)) itog = "ip не определён";
                        if (!words.TryGetValue(word, out var itogfolse)) itogfolse = "ip  определён";
                        // добавляем символ окончания сообщения 
                        itog += '\n';
                        itogfolse += '\n';
                        // отправляем перевод слова из словаря
                     
                       // int result = xmlreadr.xmlreads(word);
                        //if (result >= 1)
                       // {

                            await stream.WriteAsync(Encoding.UTF8.GetBytes(itogfolse));
                            response.Clear();
                        //}
                       // else
                       // {
                            await stream.WriteAsync(Encoding.UTF8.GetBytes(itog));
                       // }
                    }
                }
            }
            finally
            {
                tcpListener.Stop();
            }


        }
        class user
        {
            public string ip { get; }
            public string domen { get; set; }
            public user(string Ip, string Domen)
            {
                ip = Ip;
                domen = Domen;
            }
        }
        static void CopyFolder(string ip, string targetPath)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Server_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string theDate = textBox4.Text;
            string theDate2 = textBox5.Text;
            string query = $"select data_bekap from [userinfo].[dbo].[bekap] where ('{theDate}'>= data_bekap) and ('{theDate2}'<= data_bekap) ";

            SqlCommand command = new SqlCommand(query, dB.GetConnection());
            dB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            dB.GetConnection();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            dB.GetConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

