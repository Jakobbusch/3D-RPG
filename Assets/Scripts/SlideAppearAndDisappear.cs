using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideAppearAndDisappear : Slide {

	public Transform[] appearables;
	private int count;

	public override void onEnable() {
		count = 0;
		foreach (Transform t in appearables) {
			t.gameObject.SetActive (false);
		}
	}

	public override bool right ()
	{
		if (count == appearables.Length)
			return true;

		appearables [count].gameObject.SetActive (!appearables [count].gameObject.activeSelf);
		count++;
		return false;
	}

	public override bool left ()
	{
		if (count == 0)
			return true;
		count--;
		appearables [count].gameObject.SetActive (!appearables [count].gameObject.activeSelf);
		return false;
	}
}
