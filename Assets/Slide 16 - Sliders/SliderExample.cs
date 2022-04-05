using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour {

	public Slider slider;
	public Text output;

	public void valueChanged() {
		float val = slider.value;
		output.text = "" + val;
	}
}
