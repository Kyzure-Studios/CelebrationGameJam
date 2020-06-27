using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	enum PlayerState{Dead, Attack, Move, Idle};
	private PlayerState currentState;

	public int health = 3;

	public float attackCooldown = 1f;


	public float moveSpeed = 5f;
	public float jumpForce = 10f;
	public bool isGrounded = false;
	
	// Start is called before the first frame update
	void Start()
	{
		currentState = PlayerState.Idle;
	}

	// Update is called once per frame
	void Update()
	{
		switch (currentState) {
			case PlayerState.Dead:

			break;

			case PlayerState.Attack:

			break;

			case PlayerState.Move:

			break;

			case PlayerState.Idle:

			break;
		}


		if (health <= 0) {
			health = 0;
			currentState = PlayerState.Dead;
		}

		Jump();
		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;
	}

	void Attack()
	{
		if (Input.GetButtonDown("Attack"))
		{

		}
		currentState = PlayerState.Attack;
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