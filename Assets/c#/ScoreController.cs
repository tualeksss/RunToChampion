using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	public Text HpTxt;
	public static int Scoreplayer;
	public static int Hp;

	// Use this for initialization
	void Start () {
		Scoreplayer = 3;
		Hp = 1;
	
	}

	void Update(){
		HpTxt.text = "Hp: " + Scoreplayer.ToString ();
	}

	public static void rock1Score(){
		Scoreplayer--;
	}
	public static void rock2Score(){
		Scoreplayer -=2;
	}
	public static void item1Score(){
		Scoreplayer ++;
	}	
	public static void HpPlayerFall(){
		Hp--;
	}
	public static void HpPlayerAdd(){
		Hp++;
	}
}
