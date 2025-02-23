using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void SettingsButtonGame()
    {
        SceneManager.LoadSceneAsync("Settings");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
