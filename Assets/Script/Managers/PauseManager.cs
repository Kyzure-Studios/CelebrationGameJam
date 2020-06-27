using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : Manager<PauseManager> {
    
    public bool isPaused;
    private float _originalTime;

    public void Start() {
        isPaused = false;
        _originalTime = Time.timeScale;
    }
    
    public void Pause() {
        if (isPaused) {
            isPaused = false;
            UiManager.Instance.pauseCanvas.SetActive(false);
            Time.timeScale = _originalTime;
        } else {
            isPaused = true;
            UiManager.Instance.pauseCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
