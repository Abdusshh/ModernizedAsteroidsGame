using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void OnPlayButton()
    {
        LevelController.LoadNextLevel();
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
