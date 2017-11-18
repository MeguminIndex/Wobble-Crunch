using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CrushingScript : MonoBehaviour {

    bool crushing;
    Rigidbody rb;



	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.C))
        {
            Debug.Log("Crushiin....");

            crushing = true;
            rb.mass = 100; 

        }
        else
        {
           
            rb.mass = 1;
            crushing = false;
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
        }


    }
}
