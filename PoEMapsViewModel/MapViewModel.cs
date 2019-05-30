using PoEMapsModel.API;
using PoEMapsModel.Maps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoEMapsViewModel
{
    public class MapViewModel : INotifyPropertyChanged
    {
        #region Members
        private Map _map;
        private int _quantity;
        private int _numSelected;
        private bool _isChecked;
        private Price _price;
        #endregion

        #region properties
        public Map Map
        {
            get { return _map; }
            set
            {
                if (!value.Equals(_map))
                {
                    _map = value;
                    OnPropertyChanged(this, "Map");
                }
            }
        }
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (value != _isChecked)
                {
                    _isChecked = value;
                    OnPropertyChanged(this, "IsChecked");
                }
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value != _quantity)
                {
                    _quantity = value;
                    OnPropertyChanged(this, "Quantity");
                }
            }
        }
        public int NumSelected
        {
            get { return _numSelected; }
            set
            {
                if(value != _numSelected)
                {
                    _numSelected = value;
                    OnPropertyChanged(this, "NumSelected");
                }
            }
        }
        public Price Price
        {
            get { return _price; }
            set
            {
                if(value != _price)
                {
                    _price = value;
                    OnPropertyChanged(this, "Price");
                }
            }
        }
        #endregion

        public MapViewModel()
        {
            Map = new Map();
            IsChecked = false;
            Price = new Price();
            NumSelected = 1;
        }

        #region INotifyPropertyChanged
        // Declare the PropertyChanged event
        public event PropertyChangedEventHandler PropertyChanged;

        // OnPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        private void OnPropertyChanged(object sender, string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}