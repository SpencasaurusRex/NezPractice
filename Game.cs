using NezPractice.Scenes;
using Nez;
using NezPractice.Content;

public class Game : Core
{
    public Game() : base(isFullScreen: false, enableEntitySystems: true, windowTitle: "Nez Practice")
    {
    }

    protected override void Initialize()
    {
        base.Initialize();
        scene = new Dungeon();
    }
}