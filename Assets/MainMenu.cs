using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }
}
