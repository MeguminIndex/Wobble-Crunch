using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleStatScript : MonoBehaviour {

	Rigidbody rb;
	public float minMass = 1.0f;
	public float maxMass = 100.0f;
	public int health = 100;
	
	float mass = 1.0f;
	float sizeMod = 1.0f;




	// Use this for initialization
	void Start () 
	{
        ChangeSizeMod();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void ChangeSizeMod()
	{
        sizeMod = 0.5f + (mass / maxMass);
		transform.localScale = new Vector3(sizeMod, sizeMod, sizeMod);
	}
	
	public void ChangeMass(float addedMass)
	{
		
		if (mass + addedMass >= minMass && mass + addedMass <= maxMass)
		{
			mass += addedMass;
			rb.mass = mass;
		}
		else
		{
			if (mass + addedMass <= minMass)
			{
				mass = minMass;
				rb.mass = minMass;
			}
			else if (mass + addedMass >= maxMass)
			{
				mass = maxMass;
				rb.mass = maxMass;
			}
		}
		
		ChangeSizeMod();
	}

	
	
	}
