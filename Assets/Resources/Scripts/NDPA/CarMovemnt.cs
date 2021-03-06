﻿using UnityEngine;
using System.Collections;

public class CarMovemnt : MonoBehaviour {

	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;
	
	
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.autoBraking = false;
		GotoNextPoint();
	}
	
	
	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;
		
		// Set the agent to go to the currently selected destination.
		agent.destination = new Vector3(points[destPoint].position.x,-0.77f,points[destPoint].position.z);
		
		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}
	
	
	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (agent.remainingDistance < 0.5f)
			GotoNextPoint();
	}
}
