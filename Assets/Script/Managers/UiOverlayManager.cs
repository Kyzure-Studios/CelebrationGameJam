using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiOverlayManager : Manager<UiOverlayManager> {    

    new void Awake() {
        base.Awake();
        SceneManager.LoadScene("UiOverlay", LoadSceneMode.Additive);
    }
}
