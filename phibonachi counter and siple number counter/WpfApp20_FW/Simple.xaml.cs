using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp20_FW
{
    /// <summary>
    /// Interaction logic for Simple.xaml
    /// </summary>
    public partial class Simple : Window
    {
        public Simple()
        {
            InitializeComponent();
        }

        public int startNum;
        public int? endNum;
        public Thread thread;

        public void Print()
        {
            if(endNum == null)
            {
                bool a = false;
                while(true)
                {
                    if (startNum <= 1)
                    {
                        Dispatcher.Invoke(() => startNum++);
                        continue;
                    }
                    if (startNum == 2)
                    {
                        Dispatcher.Invoke(() => tb.Text += startNum + " ");
                        Dispatcher.Invoke(() => startNum++);
                        continue;
                    }
                    for (int i = 2; i * i <= startNum; i++)
                        if (startNum % i == 0)
                        {
                            Dispatcher.Invoke(() => startNum++);
                            a = true;
                            break;
                        }
                    if(a)
                    {
                        a = false;
                        continue;
                    }
                    Thread.Sleep(500);
                    Dispatcher.Invoke(() => tb.Text += startNum + " ");
                    Dispatcher.Invoke(() => startNum++);
                }
            }
            else
            {
                bool a = false;
                for (int i = startNum; i < endNum;)
                {
                    if (i <= 1)
                    {
                        i++;
                        continue;
                    }
                    if (i == 2)
                    {
                        Dispatcher.Invoke(() => tb.Text += i + " ");
                        i++;
                        continue;
                    }
                    for (int j = 2; j * j <= i; j++)
                        if (i % j == 0)
                        {
                            i++;
                            a = true;
                            break;
                        }
                    if (a)
                    {
                        a = false;
                        continue;
                    }
                    Dispatcher.Invoke(() => tb.Text += i + " ");
                    i++;
                }
            }
            thread.Abort();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if(thread != null)
            //{
            //    thread.Abort();
            //}
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //thread = new Thread(Print);
            //thread.Start();
        }
    }
}
