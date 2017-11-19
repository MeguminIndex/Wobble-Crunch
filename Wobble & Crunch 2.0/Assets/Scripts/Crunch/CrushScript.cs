using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushScript : MonoBehaviour {


    public GameObject husband;
    WallBehaviour script; 
    public bool crushed = false;

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
            script.activate = true;
        }
    }

}
