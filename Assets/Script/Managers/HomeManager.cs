using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : Manager<HomeManager> {

    public GameObject goNextEvent;

    public GameObject fightingControls;

    public GameObject movementControls;

    public void Start() {
        // Change to when parents dead
        EnableGoNextIndicator();
    }

    public void EnableGoNextIndicator() {
        fightingControls.SetActive(false);
        goNextEvent.SetActive(true);
    }

    public void ShowFightingControls() {
        movementControls.SetActive(false);
        fightingControls.SetActive(true);
    }

}
