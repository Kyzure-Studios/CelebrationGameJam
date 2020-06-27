using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiCutSceneManager : Manager<UiCutSceneManager> {

    private GameObject _textBox;
    private TextMeshProUGUI _text;
    
    private int _currentText = 0;
    private bool _isInCutScene = true;

    void Start() {
        _isInCutScene = true;
        _textBox = UiManager.Instance._textBox;
        _text = _textBox.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

    }

    void Update() {
        if (_isInCutScene) {
            if (!_textBox.activeSelf) {
                _textBox.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Space)) {
                GoNextText();
            }
        }
    }

    public void GoNextText() {
        if (_currentText >= CutSceneDictionary.size) {
            _isInCutScene = false;
            _textBox.SetActive(false);
        } else if (CutSceneDictionary.textDictionary[_currentText].name == "Skip") {
            _isInCutScene = false;
            _textBox.SetActive(false);
            _currentText++;
        } else {
            _text.text = CutSceneDictionary.textDictionary[_currentText].text;
            _currentText++;
        }
        
    }

}
