using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideShowTableau : Slide {

	private Animator anim;
	public int tableauIdx;
	public GameObject tableau;

	void Awake() {
		anim = GameObject.Find ("Main Camera").GetComponent<Animator> ();
	}

	public override void onEnable ()
	{
		anim.SetInteger ("Tableau", tableauIdx);
		if(tableau != null) tableau.SetActive (true);
	}

	public override void onDisable ()
	{
		anim.SetInteger ("Tableau", -1);
		if(tableau != null) tableau.SetActive (false);

	}
}
