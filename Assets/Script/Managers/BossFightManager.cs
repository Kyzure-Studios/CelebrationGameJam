using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightManager : Manager<BossFightManager> {
    
    public void Start() {
        UiManager.Instance.health.SetActive(true);
        StartCoroutine(StartLate());
    }

    public void BossFinish() {
        UiManager.Instance.statsCanvas.SetActive(true);
    }

    IEnumerator StartLate() {
        yield return new WaitForSeconds(1f);
        UiCutSceneManager.Instance.StartCutScene();
    }


}
