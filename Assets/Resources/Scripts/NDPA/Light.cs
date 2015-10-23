using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {

	
	float speed;
	void Start () 
	{
		speed = 0.00625f;
	}
	
	void Update () 
	{
		transform.Rotate(new Vector3(speed,0,0));
		if(transform.rotation.x >= 360)
		{
			transform.rotation = Quaternion.Euler(new Vector3(0,-45,0));
		}
	}
}
