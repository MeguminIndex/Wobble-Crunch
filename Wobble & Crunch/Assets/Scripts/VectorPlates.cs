using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPlates : MonoBehaviour {

    [SerializeField]
    private float force;
    
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if(rb != null)
        {
            //Vec3.forward is a local forward direction, we convert that into the gameobjects world direction then multiply the vector by our force
            Vector3 forceVec = gameObject.transform.TransformDirection(Vector3.forward) * force;
            //this then allows the vector plate to apply force in the direction its facing, so we can now rotate it and the force direction changes.                    
            rb.AddForce(forceVec,ForceMode.Impulse); 
        }
    }
}
