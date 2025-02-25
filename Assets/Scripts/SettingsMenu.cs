using System;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
   public void MainMenuButton()
   {
     SceneManager.LoadScene("MainMenu");
   }

    public void SetCountertoZero()
    {
      // resets counter to zero
      TriangleClick triangleClick = FindFirstObjectByType<TriangleClick>();
      triangleClick.clickCount = 0;
      Debug.Log("Counter reset to zero");
    }
}
