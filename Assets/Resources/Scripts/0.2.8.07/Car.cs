using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour 
{
	
	Vector3 ta;
	int index;
	int nindex;
	//GameObject GameManager;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		if(transform.position.x < CarMove.routes[index,nindex].x)
		{
			transform.position += new Vector3(0.1f,0,0);
		}
	}
	void OnTriggerEnter(Collider coll)
	{
		index = coll.GetComponent<MapData>().index;
		nindex = coll.GetComponent<MapData>().nindex;
	}
}
