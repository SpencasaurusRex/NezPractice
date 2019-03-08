using Microsoft.Xna.Framework;
using Nez;

namespace NezPractice.Components
{
    public class Target : Component
    {
        public Target(Vector2 position)
        {
            Position = position;
        }

        public Vector2 Position;
    }
}