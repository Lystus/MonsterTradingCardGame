using System;

namespace MonsterCardGame.Model
{
    public class Battle
    {
        public int Id { get; set; }
        public DateTime timestamp { get; set; }
        public int Player_1_id { get; set; }
        public int Player_2_id { get; set; }
        public int Winner_id { get; set; }
    }
}