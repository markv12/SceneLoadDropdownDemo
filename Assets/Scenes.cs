public enum Scenes
{
    SplashScene,
    TitleScene,
    GameScene1,
    GameScene2,
    GameScene3,
    EndScene
}

public static class ScenesExtensions
{
    public static string Name(this Scenes scene)
    {
        switch (scene)
        {
            case Scenes.SplashScene:
                return "SplashScene";
            case Scenes.TitleScene:
                return "TitleScene";
            case Scenes.GameScene1:
                return "GameScene1";
            case Scenes.GameScene2:
                return "GameScene2";
            case Scenes.GameScene3:
                return "GameScene3";
            case Scenes.EndScene:
                return "EndScene";
            default:
                return "Scene Not Found";
        }
    }
}
