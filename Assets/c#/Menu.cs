using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public int buttonWidth = 84;
	public int buttonHeight = 60;
	// Use this for initialization
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "PLAY!")) {
			Application.LoadLevel("Runtochampion");
			GetComponents<AudioSource> () [0].Play ();
		}
	}
}
