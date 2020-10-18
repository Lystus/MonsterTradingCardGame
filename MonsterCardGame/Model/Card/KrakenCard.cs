namespace MonsterCardGame.Model.Card
{
    public class KrakenCard : Card
    {
        public override bool WinsAgainst(Card target)
        {
            return target.GetType() == typeof(SpellCard);
        }
    }
}