namespace MonsterCardGame.Model.Card
{
    public class SpellCard : Card
    {
        public override bool WinsAgainst(Card target)
        {
            return target.GetType() == typeof(KnightCard) &&
                   base.Element == Element.Water;
        }
    }
}