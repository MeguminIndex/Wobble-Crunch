using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CrushingScript : MonoBehaviour {

    bool crushing;
    Rigidbody rb;
    [SerializeField]
    private float slamMassReductionWob;

    [SerializeField]
    private float downForce;
    [SerializeField]
    private string groundPound;
	[SerializeField]
	private float upforce;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown(groundPound))
        {
           
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
            else if(collision.gameObject.tag == "Wobble")
            {
                WobbleStatScript wobwob = collision.gameObject.GetComponent<WobbleStatScript>();

                float mass = wobwob.ChangeMass(slamMassReductionWob);


				rb.AddForce(0,(mass*upforce)+2,0,ForceMode.Impulse);

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
