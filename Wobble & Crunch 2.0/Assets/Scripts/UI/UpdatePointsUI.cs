using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class UpdatePointsUI : MonoBehaviour {

    Text pText;
    ScoreManagerScript SM;

    public string textPrefix;

	// Use this for initialization
	void Start () {
        pText = GetComponent<Text>();
        SM = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManagerScript>();
	}

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log("Point late");
        if (SM == null)
            return;
        Debug.Log("SM not null");

        pText.text = textPrefix + SM.GetPoints().ToString();

	}
}
