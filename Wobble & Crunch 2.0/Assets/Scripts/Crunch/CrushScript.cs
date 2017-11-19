﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushScript : MonoBehaviour {


    public GameObject husband;
    WallBehaviour script; 
    public bool crushed = false;

    public bool x = false;
    public bool y = true;
    public bool z = false;

    void Start()
    {
        script = husband.GetComponent<WallBehaviour>();
    }
   
    public void Crush()
    {
       
        if (!crushed)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
            crushed = true;
            if (y)
                script.v_on = true;
            if (x)
                script.h_on = true;
            if(z)
                script.z_on = true;
        }
    }

}
