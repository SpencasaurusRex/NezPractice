using Microsoft.Xna.Framework;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class CardMover : EntityProcessingSystem
    {
        float speed = .1f;
        float maxVelocity = 200f;

        public CardMover() : base(new Matcher().all(typeof(Card), typeof(Target)))
        {
        }

        public override void process(Entity entity)
        {
            var target = entity.getComponent<Target>();
            Vector2 delta = target.Position - entity.position;
            if (delta.LengthSquared() > maxVelocity * maxVelocity)
            {
                var ratio = maxVelocity / delta.Length();
                delta.X *= ratio;
                delta.Y *= ratio;
            }

            entity.position += delta * speed;
        }
    }
}
