using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsAnimation : MonoBehaviour {
    public void ReadyPizza() {
        StatsManager.Instance._isPizzaReady = true;
    }

    public void ReadyHostage() {
        StatsManager.Instance._isHostageReady = true;
    }

    public void ReadyChicken() {
        StatsManager.Instance._isChickenReady = true;
    }

    public void ReadyTime() {
        StatsManager.Instance._isTimeReady = true;
    }
}
