using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour {

    public Transform target;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!target)
            return;


        transform.LookAt(target);
        transform.Translate((Vector3.right * rotateSpeed) * Time.deltaTime);

    }
}
