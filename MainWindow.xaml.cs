using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace MiniGame1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeSnake();
            InitializeGame();
        }

     

        private void InitializeSnake()
        {
            Snake snake = new Snake();
            snake.Width = 100;
            snake.Height = 100;
            this.GamePanel.AddSnake(snake);
            this.GamePanel.MoveSnake();
            //MainGrid.Children.Add(snake);
        }

        private void InitializeGame()
        {
            //Dispatcher
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    this.GamePanel.Dispatcher.Invoke(new Action(() => { this.GamePanel.MoveSnake(); }));
                }
                   
                }).Start();
           
            //this.GamePanel.Dispatcher.in

        }
    }
}
