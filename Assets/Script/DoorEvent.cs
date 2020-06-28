using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour {

    private bool _isTriggered = false;

    private void OnTriggerStay2D(Collider2D other) {
        if (Input.GetKeyDown(KeyCode.F) && !_isTriggered) {
            _isTriggered = true;
            LevelManager.Instance.FadeToLevel(2);
        }
    }

}
