using Microsoft.Xna.Framework;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class CardMover : EntityProcessingSystem
    {
        float speed = .01f;

        public CardMover() : base(new Matcher().all(typeof(Card), typeof(Target)))
        {
        }

        public override void process(Entity entity)
        {
            var target = entity.getComponent<Target>();
            Vector2 delta = target.Position - entity.position;

            entity.position += delta * speed;
        }
    }
}
