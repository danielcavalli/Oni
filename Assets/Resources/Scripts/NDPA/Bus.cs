using UnityEngine;
using System.Collections;

public class Bus : MonoBehaviour {

	GameObject[] tiles; 
	public Vector3 MoveBus = Vector3.zero; 


	void Start() 
	{
		tiles = GameObject.FindGameObjectsWithTag ("Tile"); 
		BusMv ();
	} 

	void BusMv () {

		foreach (GameObject t in tiles) {
			TileBehaviour tb = t.GetComponent<TileBehaviour>(); 
			if (!GameObject.Find ("RotaManager").GetComponent<Route> ().isButtonDown && tb.RotasNumber.Count != 0) 
			{
				Debug.Log ("jfisjf");
				MoveBus = new Vector3 (0, Input.GetAxis ("Horizontal"), 0); 
				MoveBus = transform.TransformDirection(MoveBus); 
				MoveBus *= 0.5f;
	
			} 
		
		} 

		


	}
}
