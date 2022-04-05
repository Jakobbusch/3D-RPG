using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample2 : MonoBehaviour {

	public Slider slider;
	public Text t;
	public Image one, two, three;

	public void onChange() {
		float val = slider.value;
		one.fillAmount = val;
		two.fillAmount = val;
		three.fillAmount = val;
		t.text = "" + val;
	}

}
