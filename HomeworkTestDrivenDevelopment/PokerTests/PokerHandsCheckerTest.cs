using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PokerTests
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        // MSTEST reinstantiates the class on every 
        // and PokerHandsChecker is immutable
        // so we can use a field
        readonly PokerHandsChecker checker = new PokerHandsChecker();

        // "♣♦♥♠"

        [TestMethod]
        public void IsValidHandHandlesEmpty()
        {
            var hand = PokerUtils.ReadHand("");

            var result = checker.IsValidHand(hand);

            Assert.IsFalse(result);

        }
        [TestMethod]
        public void IsValidHandHandlesLessThanFive()
        {
            var hand = PokerUtils.ReadHand("A♠");

            var result = checker.IsValidHand(hand);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidHandHandlesMoreThanFive()
        {
            var hand = PokerUtils.ReadHand("A♠ Q♥ 0♣ J♦ K♥ 2♠");

            var result = checker.IsValidHand(hand);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidHandHandlesDuplicates1()
        {
            var hand = PokerUtils.ReadHand("A♠ A♠ 0♣ J♦ K♥ 2♠");

            var result = checker.IsValidHand(hand);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidHandHandlesDuplicates2()
        {
            var hand = PokerUtils.ReadHand("A♠ A♠");

            var result = checker.IsValidHand(hand);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidHandOK1()
        {
            var hand = PokerUtils.ReadHand("A♠ Q♥ 0♣ J♦ K♥");

            var result = checker.IsValidHand(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsValidHandOK2()
        {
            var hand = PokerUtils.ReadHand("A♠ 2♥ 3♣ 4♦ 5♥");

            var result = checker.IsValidHand(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsValidHandOK3()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 2♣ 2♦ 5♥");

            var result = checker.IsValidHand(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsStraightFlushOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 3♠ 4♠ 5♠ 6♠");

            var result = checker.IsStraightFlush(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsFourOfAKindOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 2♣ 2♦ 6♥");

            var result = checker.IsFourOfAKind(hand);

            Assert.IsTrue(result);

        }


        [TestMethod]
        public void IsFullHouseOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 2♣ 3♦ 3♥");

            var result = checker.IsFullHouse(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsStraightOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 3♥ 4♣ 5♦ 6♥");

            var result = checker.IsStraight(hand);

            Assert.IsTrue(result);

        }


        [TestMethod]
        public void IsFlushOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 5♠ 7♠ 9♠ J♠");

            var result = checker.IsFlush(hand);

            Assert.IsTrue(result);

        }


        [TestMethod]
        public void IsThreeOfAKindOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 2♣ 3♦ 6♥");

            var result = checker.IsThreeOfAKind(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsTwoPairsOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 3♣ 3♦ 6♥");

            var result = checker.IsTwoPair(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsOnePairOk()
        {
            var hand = PokerUtils.ReadHand("2♠ 2♥ 3♣ 4♦ 6♥");

            var result = checker.IsOnePair(hand);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsHighCardOk()
        {
            var hand = PokerUtils.ReadHand("A♠ 2♥ 3♣ 9♦ Q♥");

            var result = checker.IsHighCard(hand);

            Assert.IsTrue(result);

        }

    }
}
