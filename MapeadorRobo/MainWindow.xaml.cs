


using System.Collections.ObjectModel;
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

namespace MapeadorRobo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Tile> Tiles { get; set; } 
            = new ObservableCollection<Tile>();

        private bool Ativo;
        private Tile TileSelecionada;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Tiles.Add(new Tile(i, j));
                }
            }
        }

        private void Cell_MouseEnter(object sender, MouseEventArgs e)
        {
            // Detecta quando o mouse entra em uma célula
            // e torna visivel o indicador

            // Evita disparar o evento muitas vezes desnecessáriamente
            if (Ativo)
            {
                var grid = sender as Grid;
                var tile = grid.DataContext as Tile;

                tile.Selecionado = Visibility.Visible;

                Ativo = false;
            }
        }

        private void Cell_MouseLeave(object sender, MouseEventArgs e)
        {
            // Detecta quando o mouse sai da célula
            // para desabilitar o indicador

            var grid = sender as Grid;
            var tile = grid.DataContext as Tile;

            tile.Selecionado = Visibility.Collapsed;

            Ativo = true;
        }
    }
}