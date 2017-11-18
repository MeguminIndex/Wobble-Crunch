
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour {

    public float pos;
    public int height = 10;
    Quaternion set;
    Vector3 posit;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        pos = transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKey("k"))
        {
            while (pos > 0 -height - 1);
            pos -= 1;
            posit = new Vector3(transform.position.x, pos,transform.position.z);
            this.transform.SetPositionAndRotation(posit, set);
        }
	}
}
