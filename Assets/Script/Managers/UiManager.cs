using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Somewhat a directory of information
public class UiManager : Manager<UiManager> {

    public GameObject _uiCanvas;
    public GameObject _textBox;

    public void Start() {
        _textBox = _uiCanvas.transform.GetChild(0).gameObject;
    }

}
