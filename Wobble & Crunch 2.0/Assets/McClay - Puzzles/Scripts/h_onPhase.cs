using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h_onPhase : MonoBehaviour {


    public bool h_on = false;
    Collider sphere;

    // Use this for initialization
    void Start () {
        sphere = gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (h_on)
            sphere.enabled = false;

        else
            sphere.enabled = true;
	}
}
