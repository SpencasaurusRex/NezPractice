using System;
using System.Collections.Generic;
using System.Linq;
using Nez;
using NezPractice.Components;
using Random = Nez.Random;

namespace NezPractice.Systems
{
    public class RandomCardSelector : EntityProcessingSystem
    {
        const int Padding = 20;
        readonly int cardWidth;
        readonly int cardHeight;
        int framesSinceLastSelection;

        public RandomCardSelector() : base(new Matcher().all(typeof(Card)))
        {
        }

        public override void process(Entity entity)
        {
        }

        protected override void process(List<Entity> entities)
        {
            if (entities.Count == 0)
            {
                return;
            }
            if (framesSinceLastSelection++ < 60) return;
            framesSinceLastSelection = 0;
            var index = Random.range(0, entities.Count);
            for (int i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];
                var card = entity.getComponent<Card>();
                card.Selected = (i == index) ? CardSelected.Right : CardSelected.None;
            }
        }
    }
}
