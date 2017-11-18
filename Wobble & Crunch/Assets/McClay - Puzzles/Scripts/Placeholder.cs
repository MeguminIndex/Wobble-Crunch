using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeholder : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("k"))
            GameControls.Respawn(gameObject);
    }


	void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Deathplane"))
        {
            Debug.Log("Ded");
            GameControls.Respawn(gameObject);
        }
    }

}
