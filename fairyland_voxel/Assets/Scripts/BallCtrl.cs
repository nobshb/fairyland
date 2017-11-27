using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtrl : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider coll){
		if (coll.tag =="Enemy") {
			coll.GetComponent<RavenCtrl> ().Hurt ();
		}
		
	}
}
