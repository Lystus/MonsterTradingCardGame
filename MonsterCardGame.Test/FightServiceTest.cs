using FluentAssertions;
using MonsterCardGame.Model.Card;
using Xunit;

namespace MonsterCardGame.Test
{
    public class FightServiceTest
    {
        [Fact]
        public void TestWaterSpellWinsAgainstKnight_ShouldBeTrue()
        {
            var spell = new SpellCard()
            {
                Element = Element.Water,
            };
            var knight = new KnightCard();
            spell.WinsAgainst(knight).Should().BeTrue();
        }
        
        [Theory]
        [InlineData(Element.Fire)]
        [InlineData(Element.Normal)]
        public void TestOtherThenWaterSpellsWinsAgainstKnight_ShouldBeFalse(Element element)
        {
            var spell = new SpellCard()
            {
                Element = element,
            };
            var knight = new KnightCard();
            spell.WinsAgainst(knight).Should().BeFalse();
        }
        
        [Fact]
        public void TestKnightWinsAgainstWaterSpell_ShouldBeFalse()
        {
            var spell = new SpellCard()
            {
                Element = Element.Water,
            };
            var knight = new KnightCard();
            knight.WinsAgainst(spell).Should().BeFalse();
        }
        
        [Theory]
        [InlineData(Element.Fire)]
        [InlineData(Element.Normal)]
        public void TestKnightWinsAgainstOtherThenWaterSpells_ShouldBeFalse(Element element)
        {
            var spell = new SpellCard()
            {
                Element = element,
            };
            var knight = new KnightCard();
            knight.WinsAgainst(spell).Should().BeFalse();
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

        [Theory]
        [InlineData(Element.Water)]
        [InlineData(Element.Fire)]
        [InlineData(Element.Normal)]
        public void TestSpellWinsAgainstKraken_ShouldBeFalse(Element element)
        {
            var spell = new SpellCard()
            {
                Element = element,
            };
            var kraken = new KrakenCard();
            spell.WinsAgainst(kraken).Should().BeFalse();
        }
    }
}