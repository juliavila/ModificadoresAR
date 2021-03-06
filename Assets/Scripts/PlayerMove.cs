﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour 
{

	const float speed = 6.0f;
	const float jumpSpeed = 10.0f;
	const float gravity = 20.0f;
	Vector3 moveDirection = Vector3.zero;

	void Update ()
	{
		CharacterController controller = GetComponent<CharacterController>();

		moveDirection.x = Input.GetAxis("Horizontal") * speed;
		moveDirection.z = Input.GetAxis("Vertical") * speed;

		if (controller.isGrounded) 
		{
			if (Input.GetButton ("Jump")) 
			{
				moveDirection.y = jumpSpeed;
			}

		}

		else 
		{
			moveDirection.y -= gravity * Time.deltaTime;
		}
		controller.Move(moveDirection * Time.deltaTime); 
	}
} 
