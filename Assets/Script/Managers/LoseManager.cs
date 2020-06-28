using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseManager : Manager<LoseManager> {
    
    private GameObject _fadeOut;
    private GameObject _loseMenu;

    public void Start() {
        _fadeOut = UiManager.Instance.loseCanvas.transform.GetChild(0).gameObject;
        _loseMenu = UiManager.Instance.loseCanvas.transform.GetChild(1).gameObject;
    }

    public void Update() {
        
    }

    public void Lose() {
        UiManager.Instance.loseCanvas.SetActive(true);
        _fadeOut.GetComponent<Animator>().SetTrigger("FadeOut");
        StartCoroutine(LoseLate());
    }

    IEnumerator LoseLate() {
        yield return new WaitForSeconds(1);
        _loseMenu.SetActive(true);
        _loseMenu.GetComponent<Animator>().SetTrigger("Reappear");
    }

    public void Restart() {
        LevelManager.Instance.FadeToLevel(SceneManager.GetActiveScene().buildIndex);
        _loseMenu.GetComponent<Animator>().SetTrigger("Disappear");
    }

    public void Quit() {
        Application.Quit();
    }

}
