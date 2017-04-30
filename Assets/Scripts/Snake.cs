using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour 
{

	private Vector2 dir = Vector2.right;
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("Move", 0.3f, 0.3f);
	}//Awake
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			dir = Vector2.right;
		}//if
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			dir = Vector2.left;
		}//else if
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			dir = Vector2.up;
		}//else if
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			dir = Vector2.down;
		}//else if
	}//Update

	void Move()
	{
		transform.Translate(dir);
	}//Move
}//
