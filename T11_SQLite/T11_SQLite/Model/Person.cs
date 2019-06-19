using SQLite;

namespace T11_SQLite.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Handle { get; set; }
        public int Existence { get; set; }
    }
}
