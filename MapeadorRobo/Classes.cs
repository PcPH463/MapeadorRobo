using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapeadorRobo
{
    public class Tile : INotifyPropertyChanged
    {
        public int X { get; set; }
        public int Y { get; set; }

        private Visibility _selecionado = Visibility.Collapsed;

        public Visibility Selecionado
        {
            get { return _selecionado; }
            set
            {
                if (_selecionado != value) { _selecionado = value; }
                OnPropertyChanged();
            }
        }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;   
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
