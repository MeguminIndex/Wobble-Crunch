using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    // Use this for initialization

    public Vector3 rotation;

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
