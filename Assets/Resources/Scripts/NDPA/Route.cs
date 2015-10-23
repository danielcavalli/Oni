using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Route : MonoBehaviour {
	
	List <RouteObject> rotas = new List <RouteObject>();
	public List <Vector3> vectors = new List <Vector3>();
	public List <Vector3> vectors2 = new List <Vector3>();
	public int IDRoute = 0;
	public bool DrawRoute; 
	public int numLists;
	public bool busSelect;
	float value;
	public GameObject text;
	public GameObject FindGameManager; 
	public bool points;
	int timer;
	Animator anim;
	public bool BusAnimController;
	bool RouteManagerAnimController;


	void Start() 
	{
		busSelect = false;
		text = GameObject.Find ("SocialText");
		FindGameManager = GameObject.Find ("GameManager");
		anim = GetComponent<Animator> ();
		BusAnimController = true;
		RouteManagerAnimController = true;
	




	}
	public void RouteCreate()
	{
		if (!FindGameManager.GetComponent<RouteManager> ().creatingRoute) {
			FindGameManager.GetComponent<RouteManager> ().creatingRoute = true; 
			FindGameManager.GetComponent<RouteManager> ().routeID++; 
			FindGameManager.GetComponent<RouteManager> ().routeTile = 0;
	
		}   

		if (RouteManagerAnimController)
		{
			anim.SetBool("ClickTheRota", false);
			RouteManagerAnimController = false;
			BusAnimController = false;
		}
	
		Social.TutorialString = "|Coloque um ponto no inicio de sua rota e outro aonde voce quer que termine. Depois, e so clicar no botao do onibus.@ #PontoNoInicio #PontoNoFinal";
		text.GetComponent<Social> ().Type1 ();
	}


	void MakeRoute()
	{
		RouteObject a = new RouteObject (numLists, vectors);
		numLists++;
		rotas.Add(a);
		//Debug.Log (rotas[numLists-1].ID);
	}
	void Update () 
	{
	
		timer--;
		if (Bus.dinheiro && points && timer <= 0) 
		{
			Money.profit += Random.Range(0,5);
			timer = 180;
		}
	}
}
