using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Somewhat a directory of information
public class UiManager : Manager<UiManager> {

    public GameObject uiCanvas;
    public GameObject pauseCanvas;
    public GameObject loseCanvas;
    public GameObject jailCanvas;
    public GameObject statsCanvas;
    public GameObject blur;
    public GameObject textBox;
    public GameObject health;

    public void Start() {
        
    }


    public void UpdateHealth(int hp) {
        foreach (Transform heart in health.transform) {
            if (hp > 0) {
                heart.gameObject.SetActive(true);
                hp--;
            } else {
                heart.gameObject.SetActive(false);
            }
        }
    }

}
