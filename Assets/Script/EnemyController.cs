using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	public int maxHealth = 10;
	int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
    }

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		// Play hurt animation
		HitStopManager.Instance.PlayHitSpark(this.transform);

		if (currentHealth <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Debug.Log("Enemy died!");
		// Die animation
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
