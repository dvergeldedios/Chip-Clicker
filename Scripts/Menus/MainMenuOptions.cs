using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainMenuoptions {


    void Start()
    {
    
    }

    public void PlayGame()
    {
        // Replace "GameScene" with the actual gamescene.
        SceneManager.LoadScene("GameScene");
    }

    // Called by the Quit button
    public void QuitGame()
    {
        // This only quits the application when built. In this editor, it doesnt.
        Application.Quit();
    }

    public void OpenSettings()
    {
        // Replace
        SceneManager.LoadScene("SettingsScene");
    }

    public void OpenShop()
    {
        // Replace 
        SceneManager.LoadScene("ShopScene");
    }
}
