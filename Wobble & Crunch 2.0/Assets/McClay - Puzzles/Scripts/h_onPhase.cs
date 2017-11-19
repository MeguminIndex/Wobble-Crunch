using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h_onPhase : MonoBehaviour {


    public bool h_on = false;
    Collider sphere;
    MeshRenderer field;

    // Use this for initialization
    void Start () {
        sphere = gameObject.GetComponent<Collider>();
        field = gameObject.GetComponent<MeshRenderer>();
	}

    // Update is called once per frame
    void Update()
    {
        if (h_on)
        {
            sphere.enabled = false;
            field.enabled = false;
        }

        else
        {
            sphere.enabled = true;
            field.enabled = true;
        }
    }
}
