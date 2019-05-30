using System.ComponentModel;
using PoEMapsViewModel.Helper;

namespace PoEMapsModel.Maps
{
    public class Map : INotifyPropertyChanged
    {
        #region members
        private int _tier;
        private string _name;
        #endregion

        #region properties
        public int Tier
        {
            get { return _tier; }
            set
            {
                if (value != _tier)
                {
                    _tier = value;
                    OnPropertyChanged(this, "Tier");
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged(this, "Name");
                }
            }
        }
        #endregion

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

        #region .Equals override
        public override int GetHashCode()
        {
            int hash = 19;
            hash = hash * 31 + Tier;
            hash = hash * 31 + Name.SafeGetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            Map map = obj as Map;
            if(obj == null)
            {
                return false;
            }

            return Name == map.Name && Tier == map.Tier;
        }
        #endregion
    }
}