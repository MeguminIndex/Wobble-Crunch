using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour {

    [SerializeField]
    private float speed;//how fast the platform will travel (used in calculating the maximum step distance)

    [SerializeField]
    private Vector3 maxAxisDistance;//the distance in 3d space to move before heading back 

    private Vector3 startPos;

  //  float lastTime = 0;
    bool forward = true;

	// Use this for initialization
	void Start () {
        startPos = transform.position;//start position is where the Platform starts at in world space
	}
	

    //private bool MaxDistanceReach(Vector3 currentPos, Vector3 endPos)
    //{
    //    if(forward)
    //    {
    //        if (currentPos.x > endPos.x)
    //            return true;
    //        if (currentPos.y > endPos.y)
    //            return true;
    //        if (currentPos.z > endPos.z)
    //            return true;

    //    }
    //    else
    //    {
    //        if (currentPos.x < endPos.x)
    //            return true;
    //        if (currentPos.y < endPos.y)
    //            return true;
    //        if (currentPos.z < endPos.z)
    //            return true;
    //    }

    //    return false;
    //}

    private void FixedUpdate()
    {

        float step = speed * Time.fixedDeltaTime;

        if (forward)
        {
           
            Vector3 endPos = startPos + maxAxisDistance;

            //Move towards retuns a distance up to the max step provided, if the distance is less than step it returns that value
            transform.position = Vector3.MoveTowards(transform.position, endPos, step);

            //when the platform reachest the end position we want it to go back the other way
            if (transform.position == endPos)
                forward = false;

     
        }
        else
        {
           
            Vector3 endPos = startPos - maxAxisDistance;
            transform.position = Vector3.MoveTowards(transform.position, endPos, step);
            if (transform.position == endPos)
                forward = true;

          
        }



    }

}
