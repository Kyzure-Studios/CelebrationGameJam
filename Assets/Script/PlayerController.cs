using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public Animator animator;

	enum PlayerState{Dead, Attack, Move, Idle};
	private PlayerState currentState;


	// Stats
	public int health = 3;

	// Movement
	public float moveSpeed = 5f;
	public float jumpForce = 10f;
	public bool isGrounded = false;

	// Combat
	public Transform attackPoint;
	public LayerMask enemyLayers;

	public float attackRange = 0.5f;
	public int attackDamage = 5;
	public int attackCooldown = 12;
	public int attackDuration = 12;


	// Start is called before the first frame update
	void Start()
	{
		currentState = PlayerState.Idle;
	}

	// Update is called once per frame
	void Update()
	{

		switch (currentState)
		{
			case PlayerState.Dead:

			break;

			case PlayerState.Attack:
			
			break;

			case PlayerState.Move:


			break;

			case PlayerState.Idle:

			break;
		}

		if (health <= 0)
		{
			currentState = PlayerState.Dead;
		}

		if (Input.GetButtonDown("Attack"))
		{
			Attack();
		}

		Jump();
		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;
	}

	void Attack()
	{
		currentState = PlayerState.Attack;

		// Play an attack animation
		animator.SetTrigger("Attack");

		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		foreach(Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyController>().TakeDamage(attackDamage);
			Debug.Log("We hit " + enemy.name);
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

	void Jump()
	{
		if (Input.GetButtonDown("Jump") && isGrounded == true)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
			Debug.Log("Jumped");
		}
	}
}