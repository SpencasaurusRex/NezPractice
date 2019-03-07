using System;
using System.Collections.Generic;
using System.Text;
using Nez;
using NezPractice.Components;

namespace NezPractice.Systems
{
    public class TextJumblerSystem : EntityProcessingSystem
    {
        public TextJumblerSystem() : base(new Matcher().all(typeof(Jumbler), typeof(Text)))
        {
        }

        public override void process(Entity entity)
        {
            var jumbler = entity.getComponent<Jumbler>();
            var text = entity.getComponent<Text>();

            text.text = GetRandomString(jumbler.length);
        }

        private string GetRandomString(int length)
        {
            StringBuilder builder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = Nez.Random.range(65, 123);
                builder.Append((char)index);
            }
            return builder.ToString();
        }
    }
}
