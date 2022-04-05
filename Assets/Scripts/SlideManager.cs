using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideManager : MonoBehaviour {

	public Slide[] slides;
	public int index = 0;

	void Start() {
		foreach (Slide s in slides) {
			s.gameObject.SetActive (false);
		}
		slides [0].gameObject.SetActive (true);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && index < slides.Length) {
			bool changeSlide = slides[index].right ();
			if (changeSlide && index < slides.Length -1) {
				slides [index].onDisable ();
				slides [index].gameObject.SetActive (false);
				index++;
				slides [index].gameObject.SetActive (true);
				slides [index].onEnable ();
			}
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && index >= 0) { 
			bool changeSlide = slides[index].left ();
			if (changeSlide && index > 0) {
				slides [index].onDisable ();
				slides [index].gameObject.SetActive (false);
				index--;
				slides [index].gameObject.SetActive (true);
				slides [index].onEnable ();
			}
		}
	}
}
