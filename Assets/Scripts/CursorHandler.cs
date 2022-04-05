using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorHandler : MonoBehaviour {

	public Image img;

	void Start() {
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update () {
		Vector3 mPos = Input.mousePosition;
		img.transform.position = mPos;
	}
}
