using FluentAssertions;
using MonsterCardGame.Model;
using MonsterCardGame.Model.Card;
using Xunit;

namespace MonsterCardGame.Test
{
    public class FightServiceTest
    {
        [Fact]
        public void TestWaterSpellWinsAgainstKnight_ShouldBeTrue()
        {
            var card1 = new SpellCard()
            {
                Element = Element.Water,
            };
            var card2 = new KnightCard();
            card1.WinsAgainst(card2).Should().BeTrue();
        }
        
        [Theory]
        [InlineData(Element.Fire)]
        [InlineData(Element.Normal)]
        public void TestOtherThenWaterSpellsWinsAgainstKnight_ShouldBeFalse(Element element)
        {
            var card1 = new SpellCard()
            {
                Element = element,
            };
            var card2 = new KnightCard();
            card1.WinsAgainst(card2).Should().BeFalse();
        }

        [Theory]
        [InlineData(Element.Water)]
        [InlineData(Element.Fire)]
        [InlineData(Element.Normal)]
        public void TestKrakenWinsAgainstSpell_ShouldBeTrue(Element element)
        {
            var spell = new SpellCard()
            {
                Element = element,
            };
            var kraken = new KrakenCard();
            kraken.WinsAgainst(spell).Should().BeTrue();
        }
    }
}