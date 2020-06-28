using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaController : MonoBehaviour
{
	public Animator animator;

	public int maxHealth = 5;
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
		GetComponent<AudioSource>().Play();
		HitStopManager.Instance.PlayHitSpark(this.transform);

		if (currentHealth <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Debug.Log("Enemy died!");
		animator.SetTrigger("Die");
        BossFightManager.Instance.BossFinish();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
