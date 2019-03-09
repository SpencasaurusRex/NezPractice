using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using NezPractice.Components;
using NezPractice.Systems;

namespace NezPractice.Content
{
    public class Battlefield : Scene
    {
        public Texture2D CardFront;
        public Texture2D CardBack;

        public override void initialize()
        {
            addRenderer(new DefaultRenderer());
            clearColor = Color.Black;

            LoadAssets();
            CreateSystems();
            CreateScene();
        }

        private void LoadAssets()
        {
            CardFront = content.Load<Texture2D>("Images/CardFront");
            CardBack = content.Load<Texture2D>("Images/CardBack");
        }

        private void CreateSystems()
        {
            addEntityProcessor(new CardCoordinator(CardFront.Width, CardFront.Height));
            addEntityProcessor(new CardMover());
            addEntityProcessor(new RandomCardSelector());
        }

        private void CreateScene()
        {
            for (int i = 0; i < 10; i++)
            {
                var card = createEntity("card" + i);

                var x = Random.range(0, Screen.width);
                var y = Random.range(0, Screen.height);
                card.position = new Vector2(x, y);

                card.addComponent(new Card());

                card.addComponent(new Sprite(CardBack));

                x = Random.range(0, Screen.width);
                y = Random.range(0, Screen.height);
                card.addComponent(new Target(new Vector2(x, y)));
            }
        }

        public override void update()
        {
            base.update();
        }
    }
}
