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
    /// Interaction logic for Phi.xaml
    /// </summary>
    public partial class Phi : Window
    {
        public Phi()
        {
            InitializeComponent();
            thread = new Thread(Print);
            thread.Start();
        }

        long a = 0, b = 1, temp;
        private Thread thread;

        private void Print()
        {
            while (true)
            {
                Dispatcher.Invoke(() => temp = a);
                Dispatcher.Invoke(() => a = b);
                Dispatcher.Invoke(() => b = temp + b);
                if(a > Math.Pow(2, 64))
                {
                    break;
                }
                Dispatcher.Invoke(() => tb.Text += a + " ");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }
    }
}
