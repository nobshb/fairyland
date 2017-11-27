using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voxelAnim : MonoBehaviour {
	public AnimationCurve ac;
	Vector3 s;
	public float playSpeed = 2;
	float timeOffset = 0;


	// Use this for initialization
	void Start () {

		s = transform.localScale;
		timeOffset = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		timeOffset += Time.deltaTime;
		float r = ac.Evaluate (timeOffset * playSpeed);
		transform.localScale = new Vector3 (s.x, s.y * r, s.z);
	}
}
