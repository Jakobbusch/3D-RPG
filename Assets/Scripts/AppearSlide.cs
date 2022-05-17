using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSlide : MonoBehaviour {

	
	void Start () {
		gameObject.SetActive (false);
	}
	
	public void flipAppear() {
		gameObject.SetActive (!gameObject.activeSelf);
	}
}
