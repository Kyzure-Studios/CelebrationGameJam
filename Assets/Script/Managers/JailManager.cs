using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailManager : MonoBehaviour {
    
    public void Start() {
        StartCoroutine(LateJail());    
    }

    IEnumerator LateJail() {
        yield return new WaitForSeconds(5f);
        UiManager.Instance.jailCanvas.SetActive(true);
        yield return new WaitForSeconds(28f);
        UiManager.Instance.jailCanvas.transform.GetChild(2).gameObject.SetActive(true);
        UiManager.Instance.jailCanvas.transform.GetChild(2).GetComponent<Animator>().SetTrigger("Reappear");
    }

    IEnumerator LateAppearButton() {
        yield return new WaitForSeconds(28f);
        UiManager.Instance.jailCanvas.transform.GetChild(2).gameObject.SetActive(true);
        UiManager.Instance.jailCanvas.transform.GetChild(2).GetComponent<Animator>().SetTrigger("Reappear");
    }
}
