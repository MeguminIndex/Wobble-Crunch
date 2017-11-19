
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour {

    public float pos;
    public int height = 10;
    Quaternion set;
    Vector3 posit;
    Rigidbody rb;
    public bool v_on = false;
    public bool h_on = false;


	// Use this for initialization
	void Start () {
        pos = transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {

        if (pos < 0 - height - 1)
            v_on = false;

        if (v_on)
            Vertical();

        if (pos < 0 - height - 1)
            h_on = false;

        if (h_on)
            Horizontal();
        
	}

    public void Horizontal()
    {
        pos -= .3f;
        posit = new Vector3(pos, transform.position.y, transform.position.z);
        this.transform.SetPositionAndRotation(posit, set);
    }

    public void Vertical()
    {
        pos -= .3f;
        posit = new Vector3(transform.position.x, pos, transform.position.z);
        this.transform.SetPositionAndRotation(posit, set);
    }
}
