using UnityEngine;
using System.Collections;

public class PopManager : MonoBehaviour {

	public int pop;
	
	void Start () 
	{
		pop = 10 * (Mathf.FloorToInt(transform.localScale.y + transform.localScale.x + transform.localScale.z));
	}

	void Update () 
	{
		
	}
}
