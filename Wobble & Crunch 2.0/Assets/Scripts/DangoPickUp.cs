using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoPickUp : MonoBehaviour {

    [SerializeField]
    private float points;

    ScoreManagerScript SM;

    void Start()
    {
        SM = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManagerScript>();
    }


    void OnTriggerEnter(Collider other)
    {
        

        if(other.tag == "Crunch" || other.tag =="Wobble")
        {
            Debug.Log("Points picke up");
            if(SM != null)
            {
                SM.AddPoints(points);
                Debug.Log("Added points");
            }
            Destroy(gameObject);

        }


    }
}
