﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {
    GameController gameController;
    public string death;

    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        

        if (Input.GetKey("k"))
            Respawner.Respawn(gameObject);
    }


	void OnTriggerEnter(Collider other)
    {

		Debug.Log("Me ded");
        if (other.tag == "Deathplane")
        {
            Respawner.Respawn(gameObject);/*
            gameController.CallEvent(death);
            Debug.Log("Me ded");*/
        }
    }

}
