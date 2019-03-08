using System.Collections.Generic;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class CardCoordinator : EntityProcessingSystem
    {
        Deck deck;
        
        public CardCoordinator(Deck deck) : base(new Matcher().all(typeof(Card), typeof(Target)))
        {
            this.deck = deck;
        }

        public override void process(Entity entity)
        {
        }

        protected override void process(List<Entity> entities)
        {
            float xPosition = 0;
            foreach (var entity in entities)
            {
                var target = entity.getComponent<Target>();
                target.Position.X = xPosition;
                xPosition += 100;
            }
        }
    }
}
