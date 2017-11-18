﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CrushingScript : MonoBehaviour {

    bool crushing;
    Rigidbody rb;

    [SerializeField]
    private float downForce;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Crushiin....");
            rb.AddForce(new Vector3(0, -downForce,0),ForceMode.Impulse);
            crushing = true;
           // rb.mass = 1; 

        }
        
		
	}


    void OnCollisionEnter(Collision collision)
    {
        if (crushing)
        {
            if (collision.gameObject.tag == "Crushable")
            {

                CrushScript crushS = collision.gameObject.GetComponent<CrushScript>();
                if (crushS != null)
                {
                    crushS.Crush();


                }

            }

            rb.mass = 1;
            crushing = false;
        }

        
    }


    void OnCollisionStay(Collision collision)
    {
        if(crushing)
        {
           // rb.mass = 1;
            crushing = false;
        }
    }
}