using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSlide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	public void flipAppear() {
		gameObject.SetActive (!gameObject.activeSelf);
	}
}
