using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour {

    public GameObject door;
    WallBehaviour stuff;
    
	void Start () {
		stuff = door.GetComponent<WallBehaviour>();        
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            WallBehaviour.drop = true;
    }

}
