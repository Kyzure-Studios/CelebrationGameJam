using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightManager : MonoBehaviour {
    
    public void Start() {
        UiManager.Instance.health.SetActive(true);
        StartCoroutine(StartLate());
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.K)) {
            BossFinish();
        }
    }

    public void BossFinish() {
        UiManager.Instance.statsCanvas.SetActive(true);
    }

    IEnumerator StartLate() {
        yield return new WaitForSeconds(1f);
        UiCutSceneManager.Instance.StartCutScene();
    }


}
