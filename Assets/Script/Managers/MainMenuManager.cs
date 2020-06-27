using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : Manager<MainMenuManager> {

    public void StartGame() {
        LevelManager.Instance.FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void About() {
        print("About");
    }

    public void QuitGame() {
        Application.Quit();
    }

}
