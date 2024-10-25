using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Организовать доступ к файлу на диске из двух различных потоков. В файле хранится информация о банковском счете. 
//    Поток 1 увеличивает значение счета на единицу в одну секунду. Поток 2 выводит в окно AfxMessageBox величину 
//    счета в произвольный момент времени. Для синхронизации доступа к данным использовать объект критической секции. 
//    Предусмотреть команду остановки выполнения потоков.

namespace lab7
{
    public partial class Form1 : Form
    {
       static string fileName = "File.txt";
        int value = 0;
        int timer = 0;
        int currentValue = 0;
        object locker = new object();
        Random rnd = new Random();
        

        Thread thread1, thread2;
        public Form1()
        {
            InitializeComponent();
            using(StreamReader reader = new StreamReader(fileName))
            {
                amount.Text = reader.ReadLine();
            }
            thread1 = new Thread(fun1);
            thread2 = new Thread(fun2);
            stopThread1.Enabled = false;
            stopThread2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fun1()
        {
            value = Convert.ToInt32(amount.Text);
            while (true)
            {
                Thread.Sleep(1000);
                timer = Convert.ToInt32(time.Text);
                value++;
                using(StreamWriter writer = new StreamWriter(fileName, false))
                {
                    writer.WriteLine(value.ToString());
                }
                timer++;
                time.Text = timer.ToString();
                
            }
        }
        public void fun2()
        {
            while (true)
            {
                int n = rnd.Next(5, 10);
                Thread.Sleep(n * 1000);
                lock(locker){
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        currentValue = Convert.ToInt32(reader.ReadLine());
                    }
                }
                MessageBox.Show(
                        "Текущее значение счета: " + currentValue,
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
            }
            
        }

        private void startThread1_Click(object sender, EventArgs e)
        {
            thread1.Start();
            startThread1.Enabled = false;
            stopThread1.Enabled = true;
        }

        private void stopThread1_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            startThread1.Enabled = true;
            stopThread1.Enabled = false;
        }

        private void startThread2_Click(object sender, EventArgs e)
        {
            thread2.Start();
            startThread2.Enabled = false;
            stopThread2.Enabled = true;
        }

        private void stopThread2_Click(object sender, EventArgs e)
        {
            thread2.Abort();
            startThread2.Enabled = true;
            stopThread2.Enabled = false;
        }

        
    }
}
