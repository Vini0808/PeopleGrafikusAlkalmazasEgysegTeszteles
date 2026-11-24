
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

namespace PeopleGrafikusAlkalmazasEgysegTeszteles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        People p = new People();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p.UjSzemely(int.Parse(EletkorBevitel.Text));
                EletkorBevitel.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double atlag = p.AtlagEletkor(int.Parse(MinFel.Text), int.Parse(MaxFel.Text));
                MinFel.Clear();
                MaxFel.Clear();

                atlagSzamitasMutatas.Text = atlag.ToString();
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}