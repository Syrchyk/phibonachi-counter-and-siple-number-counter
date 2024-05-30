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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20_FW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Thread thread1;
        private Thread thread2;
        private Simple win1;
        private Phi win2;
        private int stN;
        private int? enN;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(thread1 != null)
            {
            }
            else
            {
                SimpleThread();
                thread1 = new Thread(win1.Print);
                thread1.Start();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(win1 != null)
            {
                win1.Close();
            }
            if(thread1 != null)
            {
                if(thread1.ThreadState == ThreadState.Suspended)
                {
                    thread1.Resume();
                }
                thread1.Abort();
            }
        }

        private void SimpleThread()
        { 
            if (Dispatcher.Invoke(() => String.IsNullOrWhiteSpace(tbStart.Text)))
            {
                Dispatcher.Invoke(() => stN = 2);
            }
            else
            {
                Dispatcher.Invoke(() => stN = Dispatcher.Invoke(() => Convert.ToInt32(tbStart.Text)));
            }
            if (Dispatcher.Invoke(() => String.IsNullOrWhiteSpace(tbStop.Text)))
            {
                Dispatcher.Invoke(() => enN = null);
            }
            else
            {
                Dispatcher.Invoke(() => enN = Dispatcher.Invoke(() => Convert.ToInt32(tbStop.Text)));
            }
            Dispatcher.Invoke(() => win1 = new Simple());
            win1.startNum = stN;
            win1.endNum = enN;
            Dispatcher.Invoke(() => win1.Show());
        }


        private void PhiThread()
        {
            Dispatcher.Invoke(() => win2 = new Phi());
            Dispatcher.Invoke(() => win2.Show());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (win2 != null)
            {
                win2.Close();
            }
            if (thread2 != null)
            {
                thread2.Abort();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (thread2 != null)
            {
            }
            else
            {
                thread2 = new Thread(PhiThread);
                thread2.Start();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(thread1.ThreadState == ThreadState.Running || thread1.ThreadState == ThreadState.WaitSleepJoin)
            {
                thread1.Suspend();
            }
            else if(thread1.ThreadState == ThreadState.Suspended)
            {
                thread1.Resume();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (thread2.ThreadState == ThreadState.Running || thread2.ThreadState == ThreadState.WaitSleepJoin)
            {
                thread2.Suspend();
            }
            else if(thread2.ThreadState == ThreadState.Suspended)
            {
                thread2.Resume();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }
    }
}
