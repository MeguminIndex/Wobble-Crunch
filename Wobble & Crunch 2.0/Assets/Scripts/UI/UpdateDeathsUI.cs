using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateDeathsUI : MonoBehaviour {


    Text pText;
    GameController GC;

    public string textPrefix;

    // Use this for initialization
    void Start()
    {
        pText = GetComponent<Text>();
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (GC == null)
            return;


        pText.text = textPrefix + GC.deaths.ToString();

    }
}
