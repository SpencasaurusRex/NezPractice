using NezPractice.Scenes;

public class Game1 : Nez.Core
{
    protected override void Initialize()
    {
        base.Initialize();
        scene = new MainMenu();
    }
}