using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour {

    private float points =0;




    public void AddPoints(float pointsToAdd)
    {
        points += pointsToAdd;
    }

    public float GetPoints()
    {
        return points;
    }


}
