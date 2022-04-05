using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Image healthBar1;
	public Image healthBar2;
	public Image healthBar3;

	public float h = 1f;

	public Transform cam;

	public void hit ()
	{
		h -= 0.3f;
		healthBar1.fillAmount = h;
		healthBar2.fillAmount = h;
		healthBar3.fillAmount = h;
		if (h < 0)
			h = 1f;
	}

	void Update() {
		healthBar2.transform.LookAt (cam);
	}
}
