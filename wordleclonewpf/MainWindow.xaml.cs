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
using System.IO;




namespace wordleclonewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public static class Global
    {
        public static string word;
    }
    public partial class MainWindow : Window
    {
        String word;
        public MainWindow()
        {
            InitializeComponent();
            tip1.Background = new SolidColorBrush(Colors.Purple);
            tip2.Background = new SolidColorBrush(Colors.Green);
            tip3.Background = new SolidColorBrush(Colors.Red);




            Random rnd = new Random();

            List<string> words = new List<String>();
            // pls update directory and add file lol
            string filename = @"C:\Users\Isaac\source\repos\wordleclonewpf\wordleclonewpf\fourdlewordlist.txt";
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
            {
                words.Add(line);
            }

            int r = rnd.Next(words.Count);

            word = words[r].ToUpper();



            int lives = 4;
            MessageBox.Show(word);
            livesblock.Text = lives.ToString();
        }





        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(livesblock.Text) > 0)
            {
                String guess = test1.Text.ToUpper();
                MessageBox.Show(word);
                livesblock.Text = (Convert.ToInt32(livesblock.Text) - 1).ToString();
                int x = -1;
                if (string.IsNullOrEmpty(guess1.Text))
                {
                    foreach (char i in guess)
                    {
                        x += 1;
                        int index = guess.IndexOf(i, x);
                        if (index == 0)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess1.Text = i.ToString();
                                    guess1.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess1.Text = (i.ToString());
                                    guess1.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess1.Text = (i.ToString());
                                guess1.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 1)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess2.Text = i.ToString();
                                    guess2.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess2.Text = (i.ToString());
                                    guess2.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess2.Text = (i.ToString());
                                guess2.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 2)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i,x)))
                                {
                                    guess3.Text = i.ToString();
                                    guess3.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess3.Text = (i.ToString());
                                    guess3.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess3.Text = (i.ToString());
                                guess3.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 3)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess4.Text = i.ToString();
                                    guess4.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess4.Text = (i.ToString());
                                    guess4.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess4.Text = (i.ToString());
                                guess4.Background = new SolidColorBrush(Colors.Red);
                            }
                            
                        }
                    }
                }
                else if (string.IsNullOrEmpty(guess21.Text))
                {
                    x = -1;
                    foreach (char i in guess)
                    {
                        x += 1;
                        int index = guess.IndexOf(i, x);
                        if (index == 0)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess21.Text = i.ToString();
                                    guess21.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess21.Text = (i.ToString());
                                    guess21.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess21.Text = (i.ToString());
                                guess21.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 1)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess22.Text = i.ToString();
                                    guess22.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess22.Text = (i.ToString());
                                    guess22.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess22.Text = (i.ToString());
                                guess22.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 2)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess23.Text = i.ToString();
                                    guess23.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess23.Text = (i.ToString());
                                    guess23.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess23.Text = (i.ToString());
                                guess23.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 3)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess24.Text = i.ToString();
                                    guess24.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess24.Text = (i.ToString());
                                    guess24.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess24.Text = (i.ToString());
                                guess24.Background = new SolidColorBrush(Colors.Red);
                            }
                            
                        }
                    }
                }
                else if (string.IsNullOrEmpty(guess31.Text))
                {
                    x = -1;
                    foreach (char i in guess)
                    {
                        x += 1;
                        int index = guess.IndexOf(i, x);
                        if (index == 0)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess31.Text = i.ToString();
                                    guess31.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess31.Text = (i.ToString());
                                    guess31.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess31.Text = (i.ToString());
                                guess31.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 1)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess32.Text = i.ToString();
                                    guess32.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess32.Text = (i.ToString());
                                    guess32.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess32.Text = (i.ToString());
                                guess32.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 2)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess33.Text = i.ToString();
                                    guess33.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess33.Text = (i.ToString());
                                    guess33.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess33.Text = (i.ToString());
                                guess33.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 3)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess34.Text = i.ToString();
                                    guess34.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess34.Text = (i.ToString());
                                    guess34.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess34.Text = (i.ToString());
                                guess34.Background = new SolidColorBrush(Colors.Red);
                            }
                            
                        }
                    }
                }
                else if (string.IsNullOrEmpty(guess41.Text))
                {
                    x = -1;
                    foreach (char i in guess)
                    {
                        x += 1;
                        int index = guess.IndexOf(i, x);
                        if (index == 0)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess41.Text = i.ToString();
                                    guess41.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess41.Text = (i.ToString());
                                    guess41.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess41.Text = (i.ToString());
                                guess41.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 1)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess42.Text = i.ToString();
                                    guess42.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess42.Text = (i.ToString());
                                    guess42.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess42.Text = (i.ToString());
                                guess42.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 2)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess43.Text = i.ToString();
                                    guess43.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess43.Text = (i.ToString());
                                    guess43.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess43.Text = (i.ToString());
                                guess43.Background = new SolidColorBrush(Colors.Red);
                            }

                        }
                        else if (index == 3)
                        {
                            if (word.Contains(i))
                            {
                                if (index.Equals(word.IndexOf(i, x)))
                                {
                                    guess44.Text = i.ToString();
                                    guess44.Background = new SolidColorBrush(Colors.Purple);
                                }
                                else
                                {
                                    guess44.Text = (i.ToString());
                                    guess44.Background = new SolidColorBrush(Colors.Green);
                                }
                            }
                            else
                            {
                                guess44.Text = (i.ToString());
                                guess44.Background = new SolidColorBrush(Colors.Red);
                            }
                            
                        }
                    }
                }








                if (guess == word)
                {
                    display.Text = "You did it! Congratulations!";
                }
                else
                {
                    display.Text = "Better luck next time!";
                }


            }
        }




        private void test1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void hint_Click(object sender, RoutedEventArgs e)
        {
            display.Text = ("The first letter is " + word[0]);
        }
    }

}