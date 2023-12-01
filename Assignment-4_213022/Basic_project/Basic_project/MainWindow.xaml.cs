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

namespace Basic_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person { Name = "Zeeshan", Age = 22 };
        public MainWindow()
        {

            this.DataContext = person;
        }

        public class Person
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value != age)
                    {
                        age = value;
                    }
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }

        private void Left_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
