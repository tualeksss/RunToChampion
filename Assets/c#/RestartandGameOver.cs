using UnityEngine;
using System.Collections;

public class RestartandGameOver : MonoBehaviour {

	public GUISkin GameoverSkin;

	void Start(){
		
	}

	void OnGUI(){
		GUI.skin = GameoverSkin;
		//show HP
		if (ScoreController.Hp == 0 || ScoreController.Hp <0){
			GUI.Label (new Rect (Screen.width /2-110, Screen.height/3 + 120, 250,100),"GAMEOVER");
		//Restart
			if(GUI.Button (new Rect (Screen.width /2+20, Screen.height/2 + 150, 100,40),"RESTART")){
				Application.LoadLevel ("Runtochampion");
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 130, Screen.height / 2 + 150, 100, 40), "Menu")) {
				Application.LoadLevel("Menu");
			}
		}
	}
}
