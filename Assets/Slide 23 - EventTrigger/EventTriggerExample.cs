using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class EventTriggerExample : MonoBehaviour {

	public void click(Image img) {
		Vector3 v = Random.insideUnitSphere;
		img.color = new Color (v.x, v.y, v.z);
	}
}