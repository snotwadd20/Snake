using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D coll)
	{
		Snake snake = coll.gameObject.GetComponent<Snake>();
		if (snake != null)
		{
			snake.ateFood = true;
			Destroy(gameObject);
		}//if
	}//OnTriggerEnter2D
		
}//Food
