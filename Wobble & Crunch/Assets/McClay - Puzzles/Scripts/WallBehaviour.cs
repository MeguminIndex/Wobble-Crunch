﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour {

    public float pos;
    public int height = 10;
    Quaternion set;
    Vector3 posit;
    Rigidbody rb;
    static public bool drop = false;

	// Use this for initialization
	void Start () {
        pos = transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {
        
        
        if (pos < 0 - height - 1)
            drop = false;

        if (drop)
            Drop();
        
	}
    

    public void Drop()
    {
        pos -= .3f;
        posit = new Vector3(transform.position.x, pos, transform.position.z);
        this.transform.SetPositionAndRotation(posit, set);
    }
}
