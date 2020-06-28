using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaController : EnemyController
{
	override public void Die()
	{
		Debug.Log("Enemy died!");
		animator.SetTrigger("Die");
		collider.isTrigger = true;
        BossFightManager.Instance.BossFinish();
	}
}