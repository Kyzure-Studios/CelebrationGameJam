using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {
    
    public float time;

    public void Start() {
        StartCoroutine(DestructSelf());
    }

    IEnumerator DestructSelf() {
        yield return new WaitForSeconds(time);
        Object.Destroy(this);
    }

}
