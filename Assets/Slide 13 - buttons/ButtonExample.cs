using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExample : MonoBehaviour {

	public Text outputText;
	public InputField inputField;

	public void click() {
		print ("hej");
		outputText.text = inputField.text;
	}
}
