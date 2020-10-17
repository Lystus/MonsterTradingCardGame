namespace MonsterCardGame.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Coins { get; set; }
        public int Token { get; set; }
        public int Elo_points { get; set; }
        public int Deck_id { get; set; }

    }
}