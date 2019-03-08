using NezPractice.Scenes;
using Nez;

public class Game1 : Core
{
    public Game1() : base(isFullScreen: false, enableEntitySystems: true, windowTitle: "Nez Practice")
    {
    }

    protected override void Initialize()
    {
        base.Initialize();
        scene = new MainMenu();
    }
}