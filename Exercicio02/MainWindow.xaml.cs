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

namespace Exercicio02
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
        private Jogador[] js = new Jogador[10];
        private int k;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Jogador j = new Jogador();
            j.SetNome(txt1.Text);
            j.SetGols(int.Parse(txt2.Text));
            js[k] = j;
            k++;
            list.ItemsSource = null;
            list.ItemsSource = js;
        }

        private void Artilheiro_Click(object sender, RoutedEventArgs e)
        {
            if (k <= 0)
            {
                MessageBox.Show("Nenhum jogador foi inserido !!!");
                return;
            }
            Jogador aux = js[0];
            for (int i = 1; i < k; i++)
                if (js[i].GetGols() > aux.GetGols())
                    aux = js[i];
            MessageBox.Show(aux.ToString());

        }
    }
}
