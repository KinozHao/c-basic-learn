using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;

namespace EventSimple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            //时间间隔1s中
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            //此时间执行的时候,下面BeInTouch方法执行
            dispatcherTimer.Tick += BeInTouch;

            //开启这个事件
            dispatcherTimer.Start();
        }

        private void BeInTouch(object? sender, EventArgs e)
        {
            //触发事件后,现实当前时间
            this.timeTexstBox.Text = DateTime.Now.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
