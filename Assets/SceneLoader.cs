#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SceneLoader
{
    // % = ctrl/cmd
    // # = shift
    // & = alt
    //Example:
    [MenuItem("Scenes/Load SplashScene %1")] // ctrl/cmd + 1
    public static void LoadSplashScene() { openScene(Scenes.SplashScene); }

    [MenuItem("Scenes/Load TitleScene")]
    public static void LoadTitleScene() { openScene(Scenes.TitleScene); }

    [MenuItem("Scenes/Load GameScene1")]
    public static void LoadGameScene1() { openScene(Scenes.GameScene1); }

    [MenuItem("Scenes/Load GameScene2")]
    public static void LoadGameScene2() { openScene(Scenes.GameScene2); }

    [MenuItem("Scenes/Load GameScene3")]
    public static void LoadGameScene4() { openScene(Scenes.GameScene3); }

    [MenuItem("Scenes/Load EndScene")]
    public static void LoadEndScene() { openScene(Scenes.EndScene); }

    private const string PATH = "Assets/scenes/";
    private const string SCENE_SUFFIX = ".unity";

    private static void openScene(Scenes scene)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            EditorSceneManager.OpenScene(GetScenePath(scene.Name()), OpenSceneMode.Single);
    }

    private static string GetScenePath(string sceneName)
    {
        return PATH + sceneName + SCENE_SUFFIX;
    }
}
#endif
