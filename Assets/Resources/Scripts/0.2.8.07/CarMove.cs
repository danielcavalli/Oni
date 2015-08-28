using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour 
{

	public static Vector3[,] routes;
	public GameObject Carro;

	void Start () 
	{
		routes = new Vector3[100,100];

		//if(TileSettings.canUseSave)
			Instantiate(Carro, routes[0,0],Carro.transform.rotation);
	}

	void Update () 
	{
	}
}