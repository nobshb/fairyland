using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	static public LevelManager lm;
	public Transform player;
	public GameObject enemy;
	public float rateTime = 2;
	float myTime;

	// Use this for initialization
	void Awake () {
		lm = this;
		
	}
	
	// Update is called once per frame
	void Update () {
		myTime += Time.deltaTime;
		if (myTime > rateTime) {
			
			Vector2 r = Random.insideUnitCircle.normalized*1;
			Instantiate (enemy, new Vector3(8,0,-3) + new Vector3(r.x,0,r.y),Quaternion.identity);
			myTime -= rateTime;
		}
		
	}
}
