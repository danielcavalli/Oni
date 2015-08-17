using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour 
{
	
	Vector3 ta;
	GameObject GameManager;
	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag("GameController");
		ta = GameManager.GetComponent<CarMove>().routes[1][1];
	}
	
	void Update () 
	{
		if(transform.position.x < ta.x)
		{
			transform.position += new Vector3(1,0,0);
		}
	}
	/*void OnTriggerEnter(Collision Coll)
	{
		
	}*/
}
