using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileBehaviour : MonoBehaviour {
	
	public Material thisMaterial;
	public bool isOnRoute = false;
	public List <int> RotasNumber = new List<int>();
	//public static bool[] points;
	//public List <int> RotasNumber2 = new List<int>();
	public bool hasPoint = false;
	public GameObject prefabPoint;
	public GameObject point;
	public Material sharedMaterial;
	int index = 0;
	GameObject rota;
	
	void Start()
	{
		thisMaterial = GetComponent<MeshRenderer>().material;
		sharedMaterial = Resources.Load("Art/Materials/cinz") as Material;
		rota = GameObject.Find ("RotaManager");
		//prefabPoint = Resources.Load ("Art/prefabPoint") as GameObject;
	}
	
	void OnMouseDown()
	{
		if (GameObject.Find ("RotaManager").GetComponent<Route> ().DrawRoute && !isOnRoute && GetComponent<MeshRenderer>().sharedMaterial != sharedMaterial)
		{
			GameObject.Find ("RotaManager").GetComponent<Route> ().vectors.Add(this.gameObject.transform.position);
			RotasNumber.Add(GameObject.Find ("RotaManager").GetComponent<Route> ().numLists);
			isOnRoute = true;
			GetComponent<MeshRenderer>().material = Resources.Load("Art/Materials/cinz") as Material;
			rota.GetComponent<Route>().points = false;
			index++;
		}
		else if(GetComponent<MeshRenderer>().sharedMaterial == sharedMaterial)
		{
			hasPoint = true;
			rota.GetComponent<Route>().points = true;
			GameObject point = (GameObject)Instantiate(prefabPoint,new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z+1.3f),Quaternion.Euler (0,90,0));
			//RotasNumber2.Add(GameObject.Find ("RotaManager").GetComponent<Route> ().numLists);
		}
	}
}
