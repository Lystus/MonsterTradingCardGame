using System.Collections.Generic;

namespace MonsterCardGame.Model
{
    public class Stack
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public  List<int> Cards_id { get; set; }
    }
}