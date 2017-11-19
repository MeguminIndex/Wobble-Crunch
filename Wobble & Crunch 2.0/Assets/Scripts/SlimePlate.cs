using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePlate : MonoBehaviour {

    [SerializeField]
    private float reqMass;


    public Light[] lights;
     


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
                }
                else
                {
                   

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

            }
        }

    }

}
