using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Test : MonoBehaviour {

    public void PlayGame()
    {
        // Replace "GameScene" with the name of your actual game scene.
        SceneManager.LoadScene("GameScene");
    }

    // Called by the Quit button
    public void QuitGame()
    {
        // Note: This will only quit the application when built. In the editor, it does nothing.
        Application.Quit();
    }

    // Called by the Settings button
    public void OpenSettings()
    {
        // Replace "SettingsScene" with your settings scene name, or implement settings UI here.
        SceneManager.LoadScene("SettingsScene");
    }

    // Called by the Shop button
    public void OpenShop()
    {
        // Replace "ShopScene" with your shop scene name, or implement shop UI here.
        SceneManager.LoadScene("ShopScene");
    }
}
