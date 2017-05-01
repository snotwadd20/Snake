using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour 
{
	public GameObject tailPrefab = null;

	private List<Transform> tail = new List<Transform>();
	private Vector2 dir = Vector2.right;

	[HideInInspector]
	public bool ateFood = false;

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
		Vector2 oldHeadPos = transform.position;

		transform.Translate(dir);

		if (ateFood)
		{
			//IF you ate food, put it a new tail the spot the head ysed to be
			GameObject tailPiece = Instantiate(tailPrefab, oldHeadPos, Quaternion.identity);
			tail.Insert(0, tailPiece.transform);
			ateFood = false;
		}//if
		else if (tail.Count > 0)
		{
			//Otherwise move the last tail to where the head used to be
			tail.Last().position = oldHeadPos;
			tail.Insert(0, tail.Last());
			tail.RemoveAt(tail.Count - 1);
		}//if
	}//Move

	void OnCollisionEnter2D(Collision2D coll)
	{
		print("BAM");
	}//OnCollisionEnter2D
}//
