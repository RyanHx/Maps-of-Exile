using System;

namespace PoEMapsModel.API
{

    public class FetchModel
    {
        private Result[] _result;

        public Result[] result
        {
            get { return _result; }
            set { _result = value; }
        }

        //Constructor
        public FetchModel()
        {
            result = new Result[200];
            result.Initialize();
        }
    }

    public class Result
    {
        private string _id;
        private Listing _listing;
        private Item _item;
        private bool _gone;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Listing listing
        {
            get { return _listing; }
            set { _listing = value; }
        }
        public Item item
        {
            get { return _item; }
            set { _item = value; }
        }
        public bool gone
        {
            get { return _gone; }
            set { _gone = value; }
        }

        public Result()
        {
            listing = new Listing();
            item = new Item();
            gone = false;
        }
    }

    public class Listing
    {
        private string _method;
        private DateTime _indexed;
        private Stash _stash;
        private string _whisper;
        private Account _account;
        private Price _price;
        private string _thread_locale;
        private string _thread_id;

        public string method
        {
            get { return _method; }
            set { _method = value; }
        }
        public DateTime indexed
        {
            get { return _indexed; }
            set { _indexed = value; }
        }
        public Stash stash
        {
            get { return _stash; }
            set { _stash = value; }
        }
        public string whisper
        {
            get { return _whisper; }
            set { _whisper = value; }
        }
        public Account account
        {
            get { return _account; }
            set { _account = value; }
        }
        public Price price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string thread_locale
        {
            get { return _thread_locale; }
            set { _thread_locale = value; }
        }
        public string thread_id
        {
            get { return _thread_id; }
            set { _thread_id = value; }
        }

        public Listing()
        {
            stash = new Stash();
            account = new Account();
            price = new Price();
        }
    }

    public class Stash
    {
        private string _name;
        private int _x;
        private int _y;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    public class Account
    {
        public string name { get; set; }
        public string lastCharacterName { get; set; }
        public Online online { get; set; }
        public string language { get; set; }

        public Account()
        {
            online = new Online();
        }
    }

    public class Online
    {
        public string league { get; set; }
        public string status { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
    }

    public class Item
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string name { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public Property1[] properties { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public Category1 category { get; set; }
        public Extended extended { get; set; }
        public string note { get; set; }

        public Item()
        {
            properties = new Property1[1];
            properties.Initialize();
            category = new Category1();
            extended = new Extended();
        }

    }

    public class Category1
    {
        public object[] maps { get; set; }

        public Category1()
        {
            maps = new object[1];
            maps.Initialize();
        }
    }

    public class Extended
    {
        public Mods mods { get; set; }
        public Hashes hashes { get; set; }
        public string text { get; set; }

        public Extended()
        {
            mods = new Mods();
            hashes = new Hashes();
        }
    }

    public class Mods
    {
    }

    public class Hashes
    {
    }

    public class Property1
    {
        public string name { get; set; }
        // public object[][] values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }

        // public Property1()
        //  {
        //     values = new object[2,2] { { new object(), new object()} };
        //}
    }

}