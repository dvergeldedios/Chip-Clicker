using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackToMenuButton()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}