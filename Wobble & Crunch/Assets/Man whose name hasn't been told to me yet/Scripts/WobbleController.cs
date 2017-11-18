using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleController : MonoBehaviour 
{
	public string HorizontalControl = "Horizontal";
	public string VerticalControl = "Vertical";
	public string jumpControl = "";
	public Vector3 velocity;
	Rigidbody rb;
	Vector3 rotation;
	float movespeed = 1.0f;
	float jumpSpeed = 1.0f;
	
	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float inputX = Input.GetAxis(HorizontalControl);
		float inputY = Input.GetAxis(VerticalControl);
		
		if (Input.GetButton(jumpControl))
		{
			
			
			velocity = new Vector3(inputX * movespeed, 1.0f * jumpSpeed, inputY * movespeed);
		}
		else
		{
			velocity = new Vector3(inputX * movespeed, 0.0f , inputY * movespeed);
		}
		
		
		rb.velocity = velocity;
	}
}
