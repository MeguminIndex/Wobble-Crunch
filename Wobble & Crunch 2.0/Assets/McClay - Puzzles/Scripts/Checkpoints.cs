using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

	public int me;
    GameObject this_spawn;

	void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Wobble" || other.tag == "Crunch")
		{
			Respawner.num = me;
		}
    }
    void Start()
    {
        StartCoroutine(LateStart(1));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Your Function You Want to Call
        this_spawn = gameObject;
        for (int i = 0; i < Respawner.children.Count; i++)
        {
            if (Respawner.children[i] == this_spawn)
            {
                me = i;
            }
        }
    }

    
	
	void Update () {
		
	}
}
