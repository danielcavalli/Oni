using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	float AxisSpeed;
	float ZoomRotation = 1;
	
	void Update () 
	{
		//Axis View
		if(Input.GetKey("q"))
		{
			AxisSpeed = -1f;
			transform.eulerAngles += new Vector3(0,AxisSpeed * ZoomRotation,0);
		}
		else
		{
			AxisSpeed = 0;
		}
	}
}
