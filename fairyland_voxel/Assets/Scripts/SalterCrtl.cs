using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalterCrtl : MonoBehaviour {

	public float speed = 6;
	public float rotateSpeed = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (Vector3.up * Time.deltaTime * -rotateSpeed);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
		}
	}
}
