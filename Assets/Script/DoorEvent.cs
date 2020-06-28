using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour {

    public bool _isAtDoor = false;

    private void OnTriggerStay2D(Collider2D other) {
        InputManager.Instance._isAtDoor = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        InputManager.Instance._isAtDoor = false;
    }

}
