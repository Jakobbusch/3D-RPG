using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Slide : MonoBehaviour {

	void Start() {
		init ();
	}

	public virtual void init() {

	}

	public virtual bool right (){ return true;
	}
	public virtual bool left(){ return true;
	}
	public virtual void onEnable (){
	}
	public virtual void onDisable(){}
		
}
