using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	public float angle = 10f;
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, Vector3.up, angle * Time.deltaTime);
	}
}
