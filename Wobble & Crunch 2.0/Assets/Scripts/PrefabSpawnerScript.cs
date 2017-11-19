using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnerScript : MonoBehaviour {

    [SerializeField]
    private GameObject prefab;

    private bool itemTaken = true;

    [SerializeField]
    private float coolDown;

    [SerializeField]
    private string[] tags;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (itemTaken)
        {
            itemTaken = false;
            StartCoroutine(SpawnItem());
        }
		
	}

    private IEnumerator SpawnItem()
    {

        yield return new WaitForSeconds(coolDown);

        Instantiate(prefab,transform.position,Quaternion.identity);
      

    }



    void OnTriggerEnter(Collider other)
    {
        foreach(var tag in tags)
        {
            if(other.tag == tag)
            {
                itemTaken = true;
                break;
            }
        }



    }
}
