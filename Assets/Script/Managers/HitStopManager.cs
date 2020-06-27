using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStopManager : Manager<HitStopManager>
{
  public GameObject hitSparkPrefab;
	public bool timeStop;

    // Start is called before the first frame update
    void Start()
    {
		timeStop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayHitSpark(Transform location) 
    {
      GameObject hitSpark = Object.Instantiate(hitSparkPrefab, location);
      hitSpark.transform.position = location.position;
    }
}
