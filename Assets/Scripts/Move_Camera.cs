using UnityEngine;
using System.Collections;

public class Move_Camera : MonoBehaviour 
{
	
	float speed = 0.05f;

	void Start () 
	{
		
	}

	void Update () 
	{
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-speed,0,0);
		}
		if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.position += new Vector3(speed,0,0);
		}
		if(Input.GetKey (KeyCode.UpArrow))
		{
			transform.position += new Vector3(0,0,speed);
		}
		if(Input.GetKey (KeyCode.DownArrow))
		{
			transform.position += new Vector3(0,0,-speed);
		}
	}
}
