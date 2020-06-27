using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Somewhat a directory of information
public class UiManager : Manager<UiManager> {

    public GameObject uiCanvas;
    public GameObject pauseCanvas;
    public GameObject textBox;

    public void Start() {
        textBox = uiCanvas.transform.GetChild(0).gameObject;
    }

}
