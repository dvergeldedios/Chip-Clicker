using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public void SettingsButton()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
