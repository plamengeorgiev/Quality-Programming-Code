using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;
namespace PokerTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CtorOk()
        {
            var suit = CardSuit.Hearts;
            var face = CardFace.Eight;

            var card = new Card(face, suit);

            Assert.AreEqual(suit, card.Suit);
            Assert.AreEqual(face, card.Face);
        }

        [TestMethod]
        public void ToStringOk()
        {
            var suit = CardSuit.Hearts;
            var face = CardFace.Eight;

            var card = new Card(face, suit);
            var toString = card.ToString();

            Assert.AreEqual(toString, "8♥");
        }


    }
}