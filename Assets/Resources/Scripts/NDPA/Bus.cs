using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bus : MonoBehaviour 
{
	
	public List <Vector3> thisRoute = new List<Vector3>();
	public int RouteID;
	public int currentTileOfRoute;
	float value;
	public int couste = 126;  
	public int profit;
	GameObject rota;
	public static bool dinheiro;
	bool canwalk;
	void Start() 
	{
		//HELLO DARKNESS MY OLD FRIEND;
		RouteID = 0;
		currentTileOfRoute = 0;
		rota = GameObject.Find ("RotaManager");
	}
	//Moves the bus trough the Route
	void BusMove () 
	{
		if(value >= (currentTileOfRoute+1) && !canwalk)
		{
			currentTileOfRoute = (int)value;
		}
		if(value <= (currentTileOfRoute-1) && canwalk)
		{
			currentTileOfRoute = (int)value;
		}
		if(currentTileOfRoute < 0)
		{
			canwalk = false;
		}
		if(currentTileOfRoute >= thisRoute.Count)
		{
			canwalk = true;
	
		}
		if(canwalk)
		{
			value -= 0.05f;
		}
		else
		{
			value += 0.05f;
		}
		if (thisRoute [currentTileOfRoute] != null)
		{
			this.transform.position = new Vector3(thisRoute [currentTileOfRoute].x,thisRoute [currentTileOfRoute].y+1,thisRoute [currentTileOfRoute].z);
			//			this.transform.position.y = 0.7607611f;
			//currentTileOfRoute++;
		} 
		else if (thisRoute [0] == thisRoute[thisRoute.Count - 1]) 
		{
			currentTileOfRoute = 0;
		}
	}
	void OnMouseDown()
	{
		if (GameObject.Find ("RotaManager").GetComponent<Route> ().busSelect) {
			dinheiro = true;
			for(int i =0; i < GameObject.Find ("RotaManager").GetComponent<Route> ().vectors.Count; i++)
			{
				thisRoute.Add(GameObject.Find ("RotaManager").GetComponent<Route> ().vectors[i]);
			}
			GameObject.Find ("RotaManager").GetComponent<Route> ().busSelect = false;
		}
	}
	void Update(){
		BusMove ();

	}
}
