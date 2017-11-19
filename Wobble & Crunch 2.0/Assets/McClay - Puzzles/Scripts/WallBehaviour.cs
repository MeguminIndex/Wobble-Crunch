
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour {

    public bool invert;
    int inverter = 1;
    float speed = .3f;
    public int height = 10;
    Quaternion set;
    Vector3 posit;
    Rigidbody rb;
    public bool v_on = false;
    public bool h_on = false;
    public bool z_on = false;
    public float stop;
    public float distance;
    Vector3 location;
    float speedAdd = .3f;


    // Use this for initialization
    void Start () {
        if (invert)
        {
            speed = speed * -1;
            inverter = -1;
            
        }
        location = transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (stop > distance)
            v_on = false;

        if (v_on)
        {
            Vertical();
        }

        if (stop > distance)
            h_on = false;

        if (h_on)
        {
            Horizontal();
        }

        if (stop > distance)
            z_on = false;

        if (z_on)
        {
            ZHorizontal();
        }


    }


    public void ZHorizontal()
    {
        stop += speedAdd;
        posit = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        this.transform.SetPositionAndRotation(posit, set);
    }

    public void Horizontal()
    {
        stop += speedAdd;
        posit = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        this.transform.SetPositionAndRotation(posit, set);
    }

    public void Vertical()
    {
        stop += speedAdd;
        posit = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        this.transform.SetPositionAndRotation(posit, set);
    }
}
