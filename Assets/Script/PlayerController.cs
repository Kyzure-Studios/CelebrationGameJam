using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator animator;

	public enum PlayerState { Dead, Attack, Jump, Walk };
	public PlayerState currentState;

	// Stats
	public int health = 3;

	// Movement
	public float moveSpeed = 5f;
	public float jumpForce = 30f;
	public bool isGrounded = false;

	// Combat
	public Transform attackPoint;
	public LayerMask enemyLayers;

	public float attackRange = 0.5f;
	public int attackDamage = 1;

	// Start is called before the first frame update
	void Start()
	{
		currentState = PlayerState.Walk;
	}

	// Update is called once per frame
	void Update() {}

	public void PressAttack()
	{
		if (currentState == PlayerState.Walk)
		{
			currentState = PlayerState.Attack;
			Attack();
		}
	}

	public void Attack()
	{
		animator.SetTrigger("Attack");
		StartCoroutine(AttackDuration());

		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		foreach (Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyController>().TakeDamage(attackDamage);
			Debug.Log("We hit " + enemy.name);
		}
	}

	// TODO REMOVE MAGIC NO
	IEnumerator AttackDuration()
	{
		yield return new WaitForSeconds(0.14f);
		animator.SetTrigger("AttackEnd");
		currentState = PlayerState.Walk;
	}

	public void PressJump()
	{
		if (currentState == PlayerState.Walk && isGrounded == true)
		{
			currentState = PlayerState.Jump;
			Jump();
		}
	}

	public void Jump()
	{
		animator.SetTrigger("Jump");
		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
	}

	public void PressWalk(Vector3 movement)
	{
		if (currentState == PlayerState.Dead || currentState == PlayerState.Attack) {
			return;
		}

		if (currentState == PlayerState.Jump && isGrounded == false) {
			return;
		}

		currentState = PlayerState.Walk;
		Walk(movement);
	}

	public void Walk(Vector3 movement)
	{
		transform.position += movement * Time.deltaTime * moveSpeed;

		// If movement left and facing right
		if (movement.x < 0f && transform.localScale.x < 0) {
			transform.localScale = new Vector3(2f, 2f, 2f);
		}
		// If movement right and facing left
		if (movement.x > 0f && transform.localScale.x > 0) {
			transform.localScale = new Vector3(-2f, 2f, 2f);
		}
	}


	private void OnDrawGizmosSelected()
	{
		if (attackPoint == null)
		{
			return;
		}

		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}


}