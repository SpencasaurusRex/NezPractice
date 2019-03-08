using System;
using System.Net.Mime;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using NezPractice.Components;
using NezPractice.Systems;

namespace NezPractice.Scenes
{
    public class MainMenu : Scene
    {
        public MainMenu()
        {
        }

        public override void initialize()
        {
            base.initialize();

            addRenderer(new DefaultRenderer());
            clearColor = Color.Black;

            setDesignResolution(1280, 720, SceneResolutionPolicy.ShowAllPixelPerfect);

            var macabre48Font = content.Load<SpriteFont>("Font/Macabre48");
            var word = createEntity("word", new Vector2(100, 100));
            var text = new Text(new NezSpriteFont(macabre48Font), "", new Vector2(100, 100), Color.White);
            word.addComponent(text);

            var jumbler = new Jumbler(12);
            word.addComponent(jumbler);

            addEntityProcessor(new TextJumblerSystem());
        }

        public override void update()
        {
            base.update();
        }
    }
}
