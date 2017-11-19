using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePlate : MonoBehaviour {

    [SerializeField]
    private float reqMass;


    public GameObject husband;
    WallBehaviour script;
    h_onPhase script2;

    public Light[] lights;


    void Start()
    {
        script = husband.GetComponent<WallBehaviour>();
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wobble")
        {

            WobbleStatScript wobwob = other.gameObject.GetComponent<WobbleStatScript>();
            if(wobwob != null)
            {

                float mass = wobwob.ChangeMass(0);

                if(mass >= reqMass)
                {
                    //player has met requirements;

                    foreach(var item in lights)
                    {
                        item.enabled = true;

                    }

                    try { script.h_on = true; }
                    catch { script2 = husband.GetComponent<h_onPhase>(); script2.h_on = true; }

                }
                else
                {

                    script.h_on = true;

                    float tmp = mass / reqMass;

                    int index = 0;

                    for(float i =tmp; i >= 0.25f; i -= 0.25f)
                    {
                        lights[index].enabled = true;
                        Debug.Log(index);
                        index++;
                    }


                }

            }


        }


    }


    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Wobble")
        {
            foreach (var item in lights)
            {
                item.enabled = false;

                try { script2 = husband.GetComponent<h_onPhase>(); script2.h_on = false; }
                catch { }
            }
        }

    }

}
