using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiCutSceneManager : Manager<UiCutSceneManager> {

    private GameObject _textBox;    
    private int _currentText = 0;
    private bool _isInCutScene = false;

    void Start() {
        _textBox = UiManager.Instance.textBox;
    }

    void Update() {
        if (_isInCutScene) {
            if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Space)) {
                GoNextText();
            }
        }
    }

    public void GoNextText() {
        if (_currentText >= CutSceneDictionary.size) {
            _isInCutScene = false;
            _textBox.SetActive(false);
            PauseManager.Instance.StartTime();
        } else if (CutSceneDictionary.textDictionary[_currentText].name == "Skip") {
            _isInCutScene = false;
            _textBox.SetActive(false);
            PauseManager.Instance.StartTime();
            if (CutSceneDictionary.textDictionary[_currentText].text == "Home") {
                HomeManager.Instance.ShowFightingControls();
            } else {
                // TODO: Add Alley event
            }
            _currentText++;
        } else {
            ChangeText(CutSceneDictionary.textDictionary[_currentText].name, 
                    CutSceneDictionary.textDictionary[_currentText].text);       
            _currentText++;
        }
    }

    private void ChangeText(string name, string text) {
        switch (name) {
            case "Bel":
                _textBox.transform.GetChild(0).gameObject.SetActive(true);
                _textBox.transform.GetChild(1).gameObject.SetActive(false);
                _textBox.transform.GetChild(2).gameObject.SetActive(false);
                _textBox.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
                break;
            case "Drunk Santa":
                _textBox.transform.GetChild(0).gameObject.SetActive(false);
                _textBox.transform.GetChild(1).gameObject.SetActive(true);
                _textBox.transform.GetChild(2).gameObject.SetActive(false);
                _textBox.transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
                break;
            case "Parents":
                _textBox.transform.GetChild(0).gameObject.SetActive(false);
                _textBox.transform.GetChild(1).gameObject.SetActive(false);
                _textBox.transform.GetChild(2).gameObject.SetActive(true);                
                _textBox.transform.GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
                break;
            default:
                print("Not suppose to happen");
                break;
        }
    }

    public void StartCutScene() {
        PauseManager.Instance.StopTime();
        _isInCutScene = true;
        _textBox.SetActive(true);
        GoNextText();
    }

    private void EndCutScene() {
        _isInCutScene = false;
    }

    public bool GetIsInCutScene() {
        return _isInCutScene;
    }

}
