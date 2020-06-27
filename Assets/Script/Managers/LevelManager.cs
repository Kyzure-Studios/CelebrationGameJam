using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Manager<LevelManager> {

    [SerializeField]
    private GameObject _specialEffectsCanvas = null;
    private GameObject _fadeIn;
    private GameObject _fadeOut;
    private Animator _fadeOutAnimator;

    private bool _isFading = false;

    void Start() {
        _fadeIn = _specialEffectsCanvas.transform.GetChild(0).gameObject;
        _fadeOut = _specialEffectsCanvas.transform.GetChild(1).gameObject;
        _fadeOutAnimator = _fadeOut.GetComponent<Animator>();
        FadeIn();
    }
    
    private void FadeIn() {
        if(!_isFading) {
            _isFading = true;
            StartCoroutine(LateFadeToCurrentLevel());
        }
    }

    public void FadeToLevel(int level) {
        if(!_isFading) {
            _isFading = true;
            _fadeOut.SetActive(true);
            _fadeOutAnimator.SetTrigger("FadeOut");
            StartCoroutine(LateFadeToNextLevel(level));
        }
    }

    IEnumerator LateFadeToCurrentLevel() {
        yield return new WaitForSeconds(1f);
        _fadeIn.SetActive(false);
        _isFading = false;
    }

    IEnumerator LateFadeToNextLevel(int level) {
        yield return new WaitForSeconds(1f);
        _isFading = false;
        SceneManager.LoadScene(level);
    }

    public void Quit() {
        Application.Quit();
    }


    

}
