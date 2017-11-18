using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeholder : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("k"))
            Respawner.Respawn(gameObject);
    }


	void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Deathplane"))
        {
            Respawner.Respawn(gameObject);
        }
    }

}
