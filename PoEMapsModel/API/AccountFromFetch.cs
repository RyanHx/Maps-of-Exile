using PoEMapsModel.Maps;
using System.Collections.Generic;

namespace PoEMapsModel.API
{
    public class AccountFromFetch
    {
        private string _accountName;
        private List<Map> _mapList;

        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        public List<Map> MapList
        {
            get { return _mapList; }
            set { _mapList = value; }
        }

        public AccountFromFetch()
        {
            AccountName = "";
            MapList = new List<Map>();
        }
    }
}
