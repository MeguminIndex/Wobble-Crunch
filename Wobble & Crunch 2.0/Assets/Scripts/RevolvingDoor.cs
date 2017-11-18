using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolvingDoor : MonoBehaviour {

    [SerializeField]
    private Vector3 rotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        transform.Rotate(rotation * Time.fixedDeltaTime);


	}
}
