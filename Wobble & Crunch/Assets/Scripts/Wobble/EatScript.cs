using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatScript : MonoBehaviour {

	WobbleStatScript wobbleStats;
	string eatingTag = "Edible";
	
	// Use this for initialization
	void Start () 
	{
		wobbleStats = GetComponent<WobbleStatScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnHit(Collider other)
	{
		if(other.tag == eatingTag)
		{
			EdibleScript edible = other.GetComponent<EdibleScript>();
			wobbleStats.ChangeMass(edible.massProvided);
			edible.OnEat();
		}
	}
	
	public void OnTriggerEnter(Collider other)
	{
		OnHit(other);
		
	}
	
	public void OnTriggerStay(Collider other)
	{
		OnHit(other);
		
	}
}
