﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour {

	GameController gameController;
	public string type = "wDeath";

	// Use this for initialization
	void Start () 
	{
		gameController = GameObject.FindWithTag("Gamecontroller").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Larva")
		{
			gameController.CallEvent(type);
			
		}
	}
}
