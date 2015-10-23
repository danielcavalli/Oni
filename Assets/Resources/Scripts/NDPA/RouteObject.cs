using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


class RouteObject
{
	public int ID;
	public List <Vector3> RoutePositions = new List <Vector3>();
	public RouteObject(int ID, List <Vector3> RoutePositions)
	{
		this.ID = ID;
		this.RoutePositions = RoutePositions;
	}
	/*void Start () 
	{
		//Debug.Log (ID);
	}
	void Update () 
	{
	
	}*/
}