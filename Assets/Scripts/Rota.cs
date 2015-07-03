using UnityEngine;
using System.Collections;

public class Rota : MonoBehaviour {

	static public bool canCreate = false;
	static public bool canDrag = true;
	public bool foi = true;
	//GameObject
	public GameObject street;
	//Meterials
	static public Vector3[] pos;
	public Vector3[] ta;

	void Start () 
	{
		ta = new Vector3[1000];
		canCreate = false;
	}



	public void OnMouseDown () 
	{
		canCreate = true;
	}


	void Update () 
	{
		ta[Linha.stops] = pos[Linha.stops];
	}
}
