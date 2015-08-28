using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileBehaviour : MonoBehaviour {

	public bool isOnRoute = false;
	public List <int> RotasNumber = new List<int>();


	void OnMouseDown()
	{
		if (GameObject.Find ("RotaManager").GetComponent<Route> ().isButtonDown && !isOnRoute)
		{
			GameObject.Find ("RotaManager").GetComponent<Route> ().rotas.Add(this.gameObject.transform.position);
			RotasNumber.Add(GameObject.Find ("RotaManager").GetComponent<Route> ().numLists);
			isOnRoute = true;
			GetComponent<MeshRenderer>().material = new Material("Resources/Art/Materials/Rotinha");
		}
	}
}
