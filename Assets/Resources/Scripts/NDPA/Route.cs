using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Route : MonoBehaviour {

	public List <Vector3> rotas = new List <Vector3>();
	public Dictionary <int,List<Vector3>> dictionary = new Dictionary<int, List<Vector3>> ();
	public bool isButtonDown; 
	public int numLists;

	void Start() 
	{
		numLists = 0;
		isButtonDown = false;
		 
	}
		
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.R)) {
			if (isButtonDown && rotas[0] != null)
			{	
				numLists++;
				dictionary.Add(numLists, rotas);
				rotas.RemoveRange(0,rotas.Count);
				GameObject[] tiles = GameObject.FindGameObjectsWithTag ("Tile"); 

				foreach (GameObject t in tiles) {
					TileBehaviour tb = t.GetComponent<TileBehaviour>();
					tb.isOnRoute = false;
				}
			
							
			
			}
			else
			{
				Debug.LogError("Selecione um Tile"); 
			}


			isButtonDown = !isButtonDown;
		}


		Debug.Log (isButtonDown);
	}
}
