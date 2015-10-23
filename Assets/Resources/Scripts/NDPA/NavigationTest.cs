using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NavigationTest : MonoBehaviour {

	public Transform[,] points;
	GameObject RouteManager;
	public int ID = 0;
	private int destPoint = 0;
	private NavMeshAgent agent;
	bool started = false;
	int index;
	int timer = 180;
	public RouteManager Router;
	GameObject money;
	int cash;
	

	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		RouteManager = GameObject.Find ("GameManager");
		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		points = new Transform[1000,20];
		Router = RouteManager.GetComponent<RouteManager> ();
		ID = Router.routeID;
		agent.speed = 5;
		money = GameObject.Find ("fad");
		GotoNextPoint();
	}

	void GotoNextPoint() 
	{
		// Returns if no points have been set up
		if (index == 0)
			return;
		
		// Set the agent to go to the currently selected destination.
		agent.destination = points[ID, destPoint].position;
		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % index;
	}

	void Update ()
	{
		// Choose the next destination point when the agent gets
		// close to the current one.
		cash = Random.Range (-10, 25);
		if (agent.remainingDistance < 0.05f)
		{
			timer--;
			if(timer <= 0)
			{
				GotoNextPoint();
				Money.profit += cash;
				timer = Random.Range (80,180);
			}
		}
		if(Router.onion [ID] == true && !started)
		{
			points = Router.Route;
			for(int i = 0; i < points.GetLength(1); i++)
			{
				Debug.Log(points[ID,i]);
				if(points[ID,i] != null)
				{
					index++;
				}
				else
				{
					Debug.Log (index);
				}
			}
			GotoNextPoint();
			started = true;
		}
	}
}
