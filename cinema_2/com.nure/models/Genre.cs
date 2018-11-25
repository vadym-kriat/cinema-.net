namespace cinema_2.com.nure.models
{
    public class Genre
    {
        private long _id;
        private string _name;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}