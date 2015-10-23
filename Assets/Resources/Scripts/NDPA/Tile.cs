using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour 
{
	GameObject route;
	GameObject ponto;
	public Material mat;
	public Material mat2;
	public Material mat3;
	bool[] routed;
	GameObject mypoint;
	void Start()
	{
		mat = GetComponent<MeshRenderer>().material;
		mat2 = Resources.Load ("Art/Materials/null") as Material;
		mat3 = Resources.Load ("Art/Material/Chao") as Material;
		route = GameObject.Find ("GameManager");
		ponto = GameObject.Find ("POnto");
		routed = new bool[1000];
		for(int i = 0; i < 1000; i++)
		{
			routed[i] = false;
		}
	}
	void OnMouseDown()
	{
		if(route.GetComponent<RouteManager>().creatingRoute && !routed[route.GetComponent<RouteManager>().routeID])
		{
			route.GetComponent<RouteManager>().SetPoint(transform);
			mypoint = Instantiate(ponto, new Vector3(transform.position.x, transform.position.y+0.1f, transform.position.z), ponto.transform.rotation) as GameObject;
		}
	}
}
