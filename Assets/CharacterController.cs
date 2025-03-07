﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	public float speed = 10.0F;
	public bool enable = true;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {
		if(enable)
		{
			float translation = Input.GetAxis("Vertical") * speed;
			float straffe = Input.GetAxis("Horizontal") * speed;
			translation *= Time.deltaTime;
			straffe *= Time.deltaTime;

			transform.Translate(straffe, 0, translation);
			FindObjectOfType<GameManager> ().EndGame ();

			if(Input.GetKeyDown("escape"))
			{
				Cursor.lockState = CursorLockMode.None;
			}
		}
	}
}
