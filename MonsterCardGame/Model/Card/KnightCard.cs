namespace MonsterCardGame.Model.Card
{
    public class KnightCard : Card
    {
        public override bool WinsAgainst(Card target)
        {
            return false;
        }
    }
}