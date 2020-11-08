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


namespace Third_Homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gener();
        }

        // Функция создающая  уравнение и варианты ответов на него
        public void Gener()
        {
          
            Random rand = new Random();

            int X = rand.Next(1, 50);
            MeaningX.Text = String.Format("{0}", X);

            int Y = rand.Next(1, 50);
            MeaningY.Text = String.Format("{0}", Y);

            bool bytes = rand.Next(2) > 0;
            if (bytes == true)
            {
                PlusOrMinus.Text = String.Format("+");
            }
            else
            {
                PlusOrMinus.Text = String.Format("-");
            }

            int DiffVar = rand.Next(4);
            switch (DiffVar)
            {
                case 0:
                    {
                        if (bytes == true)
                        {

                            FirstChoice.Content = String.Format("{0}", X + Y);
                            RightAnswer.Text = String.Format("{0}", X + Y);
                        }
                        else
                        {
                            FirstChoice.Content = String.Format("{0}", X - Y);
                            RightAnswer.Text = String.Format("{0}", X - Y);
                        }
                        SecondChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        ThirdChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        ForthChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                    }
                    break;

                case 1:
                    {
                        FirstChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        if (bytes == true)
                        {
                            SecondChoice.Content = String.Format("{0}", X + Y);
                            RightAnswer.Text = String.Format("{0}", X + Y);
                        }
                        else
                        {
                            SecondChoice.Content = String.Format("{0}", X - Y);
                            RightAnswer.Text = String.Format("{0}", X - Y);
                        }
                        ThirdChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        ForthChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                    }
                    break;

                case 2:
                    {
                        FirstChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        SecondChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        if (bytes == true)
                        {
                            ThirdChoice.Content = String.Format("{0}", X + Y);
                            RightAnswer.Text = String.Format("{0}", X + Y);
                        }
                        else
                        {
                            ThirdChoice.Content = String.Format("{0}", X - Y);
                            RightAnswer.Text = String.Format("{0}", X - Y);
                        }
                        ForthChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                    }
                    break;

                case 3:
                    {
                        FirstChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        SecondChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        ThirdChoice.Content = String.Format("{0}", rand.Next(-100, 100));
                        if (bytes == true)
                        {
                            ForthChoice.Content = String.Format("{0}", X + Y);
                            RightAnswer.Text = String.Format("{0}", X + Y);
                        }
                        else
                        {
                            ForthChoice.Content = String.Format("{0}", X - Y);
                            RightAnswer.Text = String.Format("{0}", X - Y);
                        }
                       
                    }
                    break;
            }
        }

        private void PlusOrMinus_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void MeaningX_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void MeaningY_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void NumberOfRA_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void FirstChoice_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void SecondChoice_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void ThirdChoice_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void ForthChoice_Checked(object sender, RoutedEventArgs e)
        {
        }


        private void RightAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Question_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void NumberOfURA_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void IntroductoryText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            // поскольку IsChecked может иметь свойство null, true или false нам необходимо преоверить принадлежат ли эти значения типу bool

            // В самих операторах условия проверяем нажата ли кнопка и совпадает ли ответ с правильным
            
            if ((FirstChoice.IsChecked ?? true) && String.Equals(RightAnswer.Text, FirstChoice.Content))
            {
                NumberOfRA.Text = String.Format("{0}", int.Parse(NumberOfRA.Text) + 1);
                MessageBox.Show("Правильный ответ!");
            }
            else
            {
                if ((SecondChoice.IsChecked ?? true) && String.Equals(RightAnswer.Text, SecondChoice.Content))
                {
                    NumberOfRA.Text = String.Format("{0}", int.Parse(NumberOfRA.Text) + 1);
                    MessageBox.Show("Правильный ответ!");
                }
                else
                {
                    if ((ThirdChoice.IsChecked ?? true) && String.Equals(RightAnswer.Text, ThirdChoice.Content))
                    {
                        NumberOfRA.Text = String.Format("{0}", int.Parse(NumberOfRA.Text) + 1);
                        MessageBox.Show("Правильный ответ!");
                    }
                    else
                    {
                        if ((ForthChoice.IsChecked ?? true) && String.Equals(RightAnswer.Text, ForthChoice.Content))
                        {
                            NumberOfRA.Text = String.Format("{0}", int.Parse(NumberOfRA.Text) + 1);
                            MessageBox.Show("Правильный ответ!");
                        }
                        else
                        {
                            MessageBox.Show("Неправильный ответ!");
                            NumberOfURA.Text = String.Format("{0}", int.Parse(NumberOfURA.Text) + 1);
                        }
                    }
                }
            }
            Gener();
        }

    
    }
}
