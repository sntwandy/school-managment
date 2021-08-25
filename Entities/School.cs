using Core.Entities.Types;

namespace Core.Entities
{
    class School
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int YearFoundation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public  SchoolTypes SchoolType { get; set; }

        public School(string name, int year, SchoolTypes type, string city) => (Name, YearFoundation) = (name, year);

        public School(string name, int year, SchoolTypes type, string country = "", string city = "")
        {
            (Name, YearFoundation, SchoolType, Country, City) = (name, year, type, country, city);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Type: {SchoolType} {System.Environment.NewLine}Country: {Country}, City:{City}";
        }
    }
}
