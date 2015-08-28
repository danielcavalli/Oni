using UnityEngine;
using System.Collections;

public class TileBehaviour : MonoBehaviour {

	public bool isOnRoute = false;

	void OnMouseDown()
	{
		if (GameObject.Find ("RotaManager").GetComponent<Rota> ().isButtonDown && !isOnRoute) {
		
			GameObject.Find ("RotaManager").GetComponent<Rota> ().rotas.Add(this.gameObject.transform.position);
			isOnRoute = true;
			GetComponent<MeshRenderer>().material = new Material("Resources/Art/Materials/Rotinha");
		}
	}
}
