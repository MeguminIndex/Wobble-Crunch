using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleStatScript : MonoBehaviour {

	Rigidbody rb;

	float mass = 1.0f;
	float sizeMod = 1.0f;
	
	
	
	

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	public void ChangeMass(float addedMass)
	{
		mass += addedMass;
		rb.mass = mass;
	}
}
