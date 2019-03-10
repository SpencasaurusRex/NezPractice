using System;
using System.Collections.Generic;
using System.Linq;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class CardCoordinator : EntityProcessingSystem
    {
        const int Padding = 20;
        readonly int cardWidth;
        readonly int cardHeight;

        public CardCoordinator(int width, int height) : base(new Matcher().all(typeof(Card), typeof(Target)))
        {
            cardWidth = width;
            cardHeight = height;
        }

        public override void process(Entity entity)
        {
        }

        protected override void process(List<Entity> entities)
        {
            float idealWidth = cardWidth + Padding;
            int bottomRowCards = entities.Select(e => e.getComponent<Card>())
                .Count(c => c.Location == CardLocation.Deck && c.Selected == CardSelected.None);
            float actualWidth = Math.Min((float)Screen.width / bottomRowCards, idealWidth); 

            float xPosition = idealWidth / 2;
            foreach (var entity in entities)
            {
                var target = entity.getComponent<Target>();
                var card = entity.getComponent<Card>();
                if (card.Selected == CardSelected.None)
                {
                    target.Position.X = xPosition;
                    target.Position.Y = Screen.height - cardHeight / 2 - Padding / 2;
                    xPosition += actualWidth;
                }
                else
                {
                    target.Position.X = Screen.width / 2 ;
                    target.Position.Y = Screen.height  / 2;
                }
            }
        }
    }
}
