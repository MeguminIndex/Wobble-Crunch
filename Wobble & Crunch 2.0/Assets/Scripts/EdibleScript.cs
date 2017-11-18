using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleScript : MonoBehaviour {

	public float massProvided = 2.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	public void OnEat()
	{
		
		Destroy(gameObject);
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
