using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailManager : MonoBehaviour {
    
    public void Start() {
        UiManager.Instance.jailCanvas.SetActive(true);
        StartCoroutine(LateAppearButton());    
    }

    IEnumerator LateAppearButton() {
        yield return new WaitForSeconds(28f);
        UiManager.Instance.jailCanvas.transform.GetChild(2).gameObject.SetActive(true);
        UiManager.Instance.jailCanvas.transform.GetChild(2).GetComponent<Animator>().SetTrigger("Reappear");
    }
}
