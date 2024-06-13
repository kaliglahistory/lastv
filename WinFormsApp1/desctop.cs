using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Transactions;
using _2;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1

{
    public partial class desctop : Form
    {
        public desctop()
        {
            InitializeComponent();
        }
        public async Task NETAsync()
        {
            int port = Convert.ToInt32(textBox4.Text);
            string ip = textBox3.Text;
            string namePC = Dns.GetHostName();
            using TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync(ip, port);
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string host = System.Net.Dns.GetHostName();
            // слова для отправки для получения перевода
            var words = new string[] { $"{localIPs[1]}" };
            // получаем NetworkStream для взаимодействия с сервером
            var stream = tcpClient.GetStream();
            // буфер для входящих данных
            var response = new List<byte>();
            int bytesRead = 10; // для считывания байтов из потока
            foreach (var word in words)
            {
                // считыванием строку в массив байт
                // при отправке добавляем маркер завершения сообщения - \n
                checkBox1.Checked = true;
                byte[] data = Encoding.UTF8.GetBytes(word + '\n');
                // отправляем данные
                await stream.WriteAsync(data);

                // считываем данные до конечного символа
                while ((bytesRead = stream.ReadByte()) != '\n')
                {
                    // добавляем в буфер
                    response.Add((byte)bytesRead);
                }
                var translation = Encoding.UTF8.GetString(response.ToArray());
                if (translation == "ip  определён")
                {

                }
            }
        }

        public string FileName { get; set; }
        private async void button2_Click(object sender, EventArgs e)

        {
            int port = Convert.ToInt32(textBox4.Text);
            string ip = textBox3.Text;
            string namePC = Dns.GetHostName();
            using TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync(ip, port);
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string host = System.Net.Dns.GetHostName();
            // слова для отправки для получения перевода
            var words = new string[] { $"{localIPs[1]}" };
            // получаем NetworkStream для взаимодействия с сервером
            var stream = tcpClient.GetStream();

            // буфер для входящих данных
            var response = new List<byte>();
            int bytesRead = 10; // для считывания байтов из потока
            foreach (var word in words)
            {
                // считыванием строку в массив байт
                // при отправке добавляем маркер завершения сообщения - \n
                byte[] data = Encoding.UTF8.GetBytes(word + '\n');
                // отправляем данные
                await stream.WriteAsync(data);

                // считываем данные до конечного символа
                while ((bytesRead = stream.ReadByte()) != '\n')
                {
                    // добавляем в буфер
                    response.Add((byte)bytesRead);
                }
               
                var translation = Encoding.UTF8.GetString(response.ToArray());
                Console.WriteLine($"Слово {word}: {translation}");
                response.Clear();
            }

            // отправляем маркер завершения подключения - END
            await stream.WriteAsync(Encoding.UTF8.GetBytes("END\n"));

            void button1_Click(object sender, EventArgs e)
            {
                FolderBrowserDialog ofd = new FolderBrowserDialog();
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                ofd.ShowDialog();
                dialog.ShowDialog();



                string sourcePath = ofd.SelectedPath; // переменная которя харнит схронемую папку дляя последующиго копривания
                string targetPath = dialog.SelectedPath;// переменная которя харнит путь к папке дляя последующиго копривания
                                                        //if ()
                                                        //{

                //}
                CopyFolder(sourcePath, targetPath);


            }
            static void CopyFolder(string sourcePath, string targetPath)
            {
                // Создаем целевую папку, если она не существует
                Directory.CreateDirectory(targetPath);

                // Копируем файлы из исходной папки в целевую папку
                foreach (string filePath in Directory.GetFiles(sourcePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    string destFile = Path.Combine(targetPath, fileName);
                    File.Copy(filePath, destFile, true); // true позволяет перезаписывать файлы
                }

                // Копируем подпапки
                foreach (string directoryPath in Directory.GetDirectories(sourcePath))
                {
                    string directoryName = Path.GetFileName(directoryPath);
                    string destDirectory = Path.Combine(targetPath, directoryName);
                    CopyFolder(directoryPath, destDirectory); // Рекурсивный вызов для подпапок
                }
            }


        }

        public async void button2_Click_1(object sender, EventArgs e)
        {

            int port = Convert.ToInt32(textBox4.Text);
            string ip = textBox3.Text;
            string namePC = Dns.GetHostName();
            using TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync(ip, port);
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string host = System.Net.Dns.GetHostName();
            // слова для отправки для получения перевода
            var words = new string[] { $"{localIPs[1]}" };
            // получаем NetworkStream для взаимодействия с сервером
            var stream = tcpClient.GetStream();
            // буфер для входящих данных
            var response = new List<byte>();
            int bytesRead = 10; // для считывания байтов из потока
            foreach (var word in words)
            {
                // считыванием строку в массив байт
                // при отправке добавляем маркер завершения сообщения - \n
                checkBox1.Checked = true;
                byte[] data = Encoding.UTF8.GetBytes(word + '\n');
                // отправляем данные
                await stream.WriteAsync(data);

                // считываем данные до конечного символа
                while ((bytesRead = stream.ReadByte()) != '\n')
                {
                    // добавляем в буфер
                    response.Add((byte)bytesRead);
                }
                var translation = Encoding.UTF8.GetString(response.ToArray());
                if (translation == "ip  определён")
                {

                }



                response.Clear();
            }

            // отправляем маркер завершения подключения - END
            await stream.WriteAsync(Encoding.UTF8.GetBytes("END\n"));
            Console.WriteLine("Все сообщения отправлены");
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            ofd.ShowDialog();
            dialog.ShowDialog();
            string sourcePath = ofd.SelectedPath;
            textBox1.Text = ofd.SelectedPath; ;// переменная которя харнит схронемую папку дляя последующиго копривания
            string targetPath = dialog.SelectedPath;
            textBox2.Text = dialog.SelectedPath;
            if (checkBox1.Checked)
            {
                CopyFolder(sourcePath, targetPath);
            }
            else
            {
                MessageBox.Show("Нет соеденения с сервером");
            }
        }

        static void CopyFolder(string sourcePath, string targetPath)
        {
                // Создаем целевую папку, если она не существует
                Directory.CreateDirectory(targetPath);

                // Копируем файлы из исходной папки в целевую папку
                foreach (string filePath in Directory.GetFiles(sourcePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    string destFile = Path.Combine(targetPath, fileName);
                    File.Copy(filePath, destFile, true); // true позволяет перезаписывать файлы
                }

                // Копируем подпапки
                foreach (string directoryPath in Directory.GetDirectories(sourcePath))
                {
                    string directoryName = Path.GetFileName(directoryPath);
                    string destDirectory = Path.Combine(targetPath, directoryName);
                    CopyFolder(directoryPath, destDirectory); // Рекурсивный вызов для подпапок
                }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}