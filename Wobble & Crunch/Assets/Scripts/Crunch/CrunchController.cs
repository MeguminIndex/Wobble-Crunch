using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CrunchController : MonoBehaviour {

    
    public Transform cameraTrans;

    Rigidbody rb;

    [SerializeField]
    private string horizontalInput;
    [SerializeField]
    private string verticalInput;
    [SerializeField]
    private string jumpInput;


    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float moveForce;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float rotationLerpSpeed;
    [SerializeField]
    private float raycastDist;

    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown(jumpInput))
            Jump();

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw(horizontalInput);
        float v = Input.GetAxisRaw(verticalInput);
        if (h != 0 || v != 0)
        {
            DoMovement(h, v);
        }

      

    }

    private void Jump()
    {
        //check that character is on the floor make sure cannot multi jump;

         Vector3 post = transform.position;

         post.y -= transform.localScale.y;

        //   Collider[] coliders = Physics.OverlapSphere(post, jumpRadius);

        //   Debug.Log("Jumping ray colliders length: " + coliders.Length);
        //  if (coliders.Length >0)
        //  {

        Ray ray = new Ray(transform.position,Vector3.down);
        Debug.DrawRay(post, Vector3.down,Color.blue,1);
        if (Physics.Raycast(ray, raycastDist))
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
      //  }

    }

    private void DoMovement(float h, float v)
    {
        

        Vector3 velocity = rb.velocity;

        Vector3 direction = Vector3.forward;
        direction.x *= h;
        direction.z *= v;


        Debug.Log(direction);

        
         
        Vector3 forceVec = cameraTrans.TransformDirection(h,0,v) * moveForce;//movement is based on direction of Camera
        Debug.Log("ForceVec: " + forceVec);

        //so if already traveling in direction add less force
        if (forceVec.x > 1 || forceVec.x < -1)
            forceVec.x /= 2;
        if (forceVec.y > 1 || forceVec.y < -1)
            forceVec.y /= 2;

        
        Debug.Log("After Mod forcevec: " + forceVec);

        forceVec.y = 0;
        rb.AddForce(forceVec);

        RotateToCameraDir();
    }

    private void RotateToCameraDir()
    {
        //lerp the rotation so its not instant
        transform.rotation = Quaternion.Lerp(transform.rotation,cameraTrans.rotation, Time.fixedDeltaTime * rotationLerpSpeed);
    }

}
