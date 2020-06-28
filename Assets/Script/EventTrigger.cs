using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour {

    public bool isTriggered = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (!isTriggered) {
            UiCutSceneManager.Instance.StartCutScene();
            isTriggered = true;
        }
    }

}
