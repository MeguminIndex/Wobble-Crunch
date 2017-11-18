using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseScript : MonoBehaviour {

	string phaseTag = "phaseThrough";
	string colliderType = "Collider";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnHit(Collider other)
	{
		if(other.tag == phaseTag)
		{
			Component[] arrayOfColliders = other.gameObject.GetComponents<Collider>();
			foreach(Collider item in arrayOfColliders)
			{
				if (item.isTrigger != true)
				{
					item.enabled = false;
				}
			}
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
	
	public void OnTriggerExit(Collider other)
	{
		if(other.tag == phaseTag)
		{
			Component[] arrayOfColliders = other.gameObject.GetComponents<Collider>();
			foreach(Collider item in arrayOfColliders)
			{
				if (item.enabled != true)
				{
					item.enabled = true;
				}
			}
		}
	}
}
