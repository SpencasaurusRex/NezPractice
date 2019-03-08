using System;
using System.Collections.Generic;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class Deck : PassiveSystem
    {
        public List<Card> Hand;

        public Deck()
        {
            Hand = new List<Card>();
        }
    }
}