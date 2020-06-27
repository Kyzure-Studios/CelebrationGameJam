using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Somewhat a directory of information
public class UiManager : Manager<UiManager> {

    public GameObject uiCanvas;
    public GameObject pauseCanvas;
    public GameObject loseCanvas;
    public GameObject textBox;
    public GameObject health;

    public void Start() {
        textBox = uiCanvas.transform.GetChild(0).gameObject;
        health = uiCanvas.transform.GetChild(1).gameObject;
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
