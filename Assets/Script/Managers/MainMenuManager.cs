using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : Manager<MainMenuManager> {

    private Animator _menu1;
    private Animator _menu2;

    void Start() {
        _menu1 = GameObject.Find("Menu1").GetComponent<Animator>();
        _menu2 = GameObject.Find("Menu2").GetComponent<Animator>();

        _menu1.SetTrigger("Reappear");
    }

    public void StartGame() {
        _menu1.SetTrigger("Disappear");
        print("yeet");
        LevelManager.Instance.FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void About() {
        _menu1.SetTrigger("Disappear");
        StartCoroutine(LateReappear(_menu2));
    }

    public void QuitGame() {
        _menu1.SetTrigger("Disappear");
        Application.Quit();
    }

    public void BackToMenu1() {
        _menu2.SetTrigger("Disappear");
        StartCoroutine(LateReappear(_menu1));
    }

    IEnumerator LateReappear(Animator menu) {
        yield return new WaitForSeconds(0.2f);
        menu.SetTrigger("Reappear");
    }

}
