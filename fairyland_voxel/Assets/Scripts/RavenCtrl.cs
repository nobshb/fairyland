using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenCtrl : MonoBehaviour {

	public Transform player;
	public float rotateSpeed;
	public Vector3 vc;
	public GameObject blood;


	// Use this for initialization
	void Start () {
		player = LevelManager.lm.player;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDri = player.position - transform.position;
		float step = rotateSpeed * Time.deltaTime;
		Vector3 newDri = Vector3.RotateTowards (transform.forward, targetDri, step, 0.0f);
		transform.rotation = Quaternion.LookRotation (newDri);
		transform.Translate (Vector3.forward * Time.deltaTime * 8);
		
	}

	public void Hurt(){
		Destroy (gameObject);
		Instantiate (blood,transform.position,Quaternion.identity); 
		
	}

}
