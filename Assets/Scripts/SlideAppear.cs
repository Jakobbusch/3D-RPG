using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideAppear : Slide {

	public Transform[] appearables;
	private int count;

	public override void init() {
		count = 0;
		foreach (Transform t in appearables) {
			t.gameObject.SetActive (false);
		}
	}

	public override bool right ()
	{
		if (count == appearables.Length)
			return true;

		appearables [count].gameObject.SetActive (true);
		count++;
		return false;
	}

	public override bool left ()
	{
		if (count == 0)
			return true;
		count--;
		appearables [count].gameObject.SetActive (false);
		return false;
	}

}
