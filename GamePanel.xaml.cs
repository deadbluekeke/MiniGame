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

namespace MiniGame1
{
    /// <summary>
    /// GamePanel.xaml 的交互逻辑
    /// </summary>
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
            InitializePanel();
        }

        private Snake snakeObject;

        private void InitializePanel()
        {
            for (int i = 0; i < Parameter.PanelColume; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width = new GridLength(10);
                ThisGamePanel.ColumnDefinitions.Add(columnDefinition);
            }
            for (int i = 0; i <Parameter.PanelRow; i++)
            {
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(10);
                ThisGamePanel.RowDefinitions.Add(rowDefinition);
            }
        }

        public void AddSnake(UserControl snake)
        {
            //Grid.r
            Grid.SetColumn(snake, 2);
            Grid.SetRow(snake, 2);
            //Grid.SetRow(snake, 1);
            ThisGamePanel.Children.Add(snake);
            snakeObject = snake as Snake;
        }

        public void MoveSnake()
        {
            var children = ThisGamePanel.Children;
            var child = children[children.Count - 1];
            // child.
            int a = new Random().Next(0, 20);
            Grid.SetColumn(child, a);
            Grid.SetRow(child, a);
            //Grid.SetRow(snake, 1);
            //ThisGamePanel.Children.Add(snake);
        }
    }
}
