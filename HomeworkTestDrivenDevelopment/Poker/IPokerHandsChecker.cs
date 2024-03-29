﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public interface IPokerHandsChecker
    {
        bool IsValidHand(IHand hand);
        bool IsStraightFlush(IHand hand);
        bool IsFourOfAKind(IHand hand);
        bool IsFullHouse(IHand hand);
        bool IsFlush(IHand hand);
        bool IsStraight(IHand hand);
        bool IsThreeOfAKind(IHand hand);
        bool IsTwoPair(IHand hand);
        bool IsOnePair(IHand hand);
        bool IsHighCard(IHand hand);
        int CompareHands(IHand firstHand, IHand secondHand);
    }
}
