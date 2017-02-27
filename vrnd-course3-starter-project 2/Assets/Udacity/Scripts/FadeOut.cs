using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public Texture aTexture;

	void autoFade() {
	
		GUI.DrawTexture (new Rect (10, 10, 60, 60), aTexture, ScaleMode.ScaleToFit, true, 10.0F);
	}
}

