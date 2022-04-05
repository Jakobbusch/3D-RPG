using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UINavigation : MonoBehaviour {

	public Text t;
	public GameObject firstButton;

	void OnEnable() {
		EventSystem.current.firstSelectedGameObject = firstButton;
		EventSystem.current.SetSelectedGameObject (firstButton);
	}

	public void click(GameObject g) {
		t.text = g.name;
	}
}

