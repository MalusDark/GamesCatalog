namespace BlazorApp.Models
{
    public class Games
    {
        private List<Game> _games;

        public Games() { 
        _games = new List<Game>();
            _games.Add(new Game(1, "Escape from Tarkov", "Shooter"));
            _games.Add(new Game(2, "Minecraft", "Sandbox"));
        }
        public void Add(Game game)
        {
            _games.Add(game);
        }
        public List<Game> GetGames()
        {
            return _games;
        }
    }
}
