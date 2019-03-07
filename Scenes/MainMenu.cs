using System;
using System.Net.Mime;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace NezPractice.Scenes
{
    public class MainMenu : Nez.Scene
    {
        SpriteFont macabre48Font;

        public MainMenu()
        {
            addRenderer(new DefaultRenderer());
            clearColor = Color.Black;
        }

        public override void initialize()
        {
            base.initialize();

            setDesignResolution(1280, 720, SceneResolutionPolicy.ShowAllPixelPerfect);
            Screen.setSize(1280, 720);

            macabre48Font = content.Load<SpriteFont>("Font/Macabre48");
            var word = createEntity("word", new Vector2(100, 100));
            var text = new Text(new NezSpriteFont(macabre48Font), "Testing", new Vector2(100, 100), Color.White);
            word.addComponent(text);
        }

        public override void onStart()
        {
        }
    }
}
