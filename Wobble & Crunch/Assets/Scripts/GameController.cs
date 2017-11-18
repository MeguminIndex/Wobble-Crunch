using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	WobbleStatScript wobbleStats;
	
	[SerializeField] private string[] events;
	
	// Use this for initialization
	void Start () 
	{
		wobbleStats = GetComponent<WobbleStatScript>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	// Methods an event may call, the index is the position in the Events array.
	void EventListing(int index)
	{
		if (index == 0)
		{
			
		}
		else if (index == 1)
		{
			
		}
		else if (index == 2)
		{
			
		}
		else if (index == 3)
		{
			
		}
		else if (index == 4)
		{
			
		}
		else if (index == 5)
		{
			
		}
		
		
	}
	
	void CallEvent(string name)
	{
		for (int i = 0; i < events.Length; i++)
		{
			if (events[i] == name)
			{
				EventListing(i);
			}
		}
	}
}
