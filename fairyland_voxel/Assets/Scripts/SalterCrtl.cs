using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalterCrtl : MonoBehaviour {

	public float acceleration = 60;
	public float rotateSpeed = 100;
    public float jumpForce = 10;
    private Rigidbody rb;

    private Vector3 velocity;
    public LayerMask layerMask;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        velocity = Vector3.zero;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Ray ray = new Ray(transform.position, transform.up * -1f); //create a ray to see if anything's under her feet
        Debug.DrawRay(ray.origin, ray.direction*0.5f) ; //visualize the ray for debug purposes
        if (Physics.Raycast(ray, 0.5f, layerMask)) //returns true if the ray hits anything on the layerMask
        {
            Debug.Log("touching ground");
            if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);  //kick her up with some force 
        }
        
        if (Input.GetKey(KeyCode.W)) rb.AddForce(transform.forward * acceleration, ForceMode.Force);

        transform.position += velocity * Time.deltaTime;

		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (Vector3.up * Time.deltaTime * -rotateSpeed);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
		}
	}
}
