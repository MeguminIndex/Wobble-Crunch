using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushScript : MonoBehaviour {


    bool crushed = false;

   
    public void Crush()
    {
       
        if (!crushed)
        {
          
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
            crushed = true;
        }
    }

}
