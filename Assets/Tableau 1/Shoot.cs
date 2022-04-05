using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public ParticleSystem fire;
	public ParticleSystem blood;
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(!fire.isPlaying && Physics.Raycast(new Ray(transform.position, transform.forward), out hit, 7f)) {
			fire.Play ();
			blood.transform.position = hit.point;
			blood.transform.rotation = transform.rotation;
			blood.Play ();
			hit.collider.gameObject.GetComponent<Health> ().hit ();
		}
		Debug.DrawRay (transform.position, transform.forward * 7f);
	}
}
