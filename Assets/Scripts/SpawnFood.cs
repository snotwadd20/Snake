using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour 
{
	public GameObject foodPrefab = null;

	public Transform borderTop = null;
	public Transform borderBottom = null;
	public Transform borderLeft = null;
	public Transform borderRight = null;

	void Spawn()
	{
		float x = Random.Range(borderLeft.position.x + 1, borderRight.position.x);
		float y = Random.Range(borderBottom.position.y + 1, borderTop.position.y);
		Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
	}//Spawn

	// Use this for initialization
	void Start () 
	{
		Spawn();
		InvokeRepeating("Spawn", 3, 4);
	}//Awake
	
	// Update is called once per frame
	void Update () 
	{
		
	}//Update
}//
