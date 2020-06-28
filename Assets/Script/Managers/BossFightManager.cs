using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightManager : MonoBehaviour {
    
    public void Start() {
        UiManager.Instance.health.SetActive(true);
    }
}
