﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	public Animator animator;
	public CapsuleCollider2D collider;

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

	public virtual void Die()
	{
		Debug.Log("Enemy died!");
		animator.SetTrigger("Die");
		collider.isTrigger = true;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
