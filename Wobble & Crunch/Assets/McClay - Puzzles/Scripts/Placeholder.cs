using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeholder : MonoBehaviour {
    GameController gameController;

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
        if (other.CompareTag("Deathplane"))
        {
            gameController.CallEvent("CrunchDeath");
            Debug.Log("Me ded");
        }
    }

}
