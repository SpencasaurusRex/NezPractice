using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;

namespace NezPractice.Scenes
{
    public class MainMenu : Scene
    {
        NezSpriteFont macabre48Font;

        public override void initialize()
        {
            base.initialize();
            macabre48Font = new NezSpriteFont(Core.content.Load<SpriteFont>("Font/Macabre48"));
            clearColor = Color.Black;
            addRenderer(new DefaultRenderer());
            setDesignResolution(1280, 720, SceneResolutionPolicy.ShowAllPixelPerfect);
        }

        public override void update()
        {
            base.update();

        }
    }
}
