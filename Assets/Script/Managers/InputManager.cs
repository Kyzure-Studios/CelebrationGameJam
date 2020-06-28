using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Manager<InputManager>
{
	[SerializeField]
	private GameObject _player;
	private PlayerController _playerController;


	// Start is called before the first frame update
	void Start()
	{
		_player = GameObject.Find("Bel");
		_playerController = _player.GetComponent<PlayerController>();
	}


	// Update is called once per frame
	void Update()
	{

		if (Input.GetButtonDown("Attack") && !UiCutSceneManager.Instance.GetIsInCutScene())
		{
			Debug.Log("Attack pressed");

			_playerController.PressAttack();
			return;
		}

		if (Input.GetButtonDown("Jump") && !UiCutSceneManager.Instance.GetIsInCutScene())
		{
			Debug.Log("Jump pressed.");

			_playerController.PressJump();
			return;
		}

		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
		_playerController.PressWalk(movement);

		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (!LevelManager.Instance.IsInJail()) {
				PauseManager.Instance.Pause();
			}
			
		}

	}
}