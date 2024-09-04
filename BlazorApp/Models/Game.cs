namespace BlazorApp.Models
{
    public class Game
    {
        private int _id;
        private string _name;
        private string _genre;

        public Game(int id, string name, string description)
        {
            this._id = id;
            this._name = name; 
            this._genre = description;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Genre { get => _genre; set => _genre = value; }
    }
}
