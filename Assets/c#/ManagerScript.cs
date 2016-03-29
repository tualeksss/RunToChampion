using UnityEngine;
using System.Collections;

public class ManagerScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D hitInfo){
		//rock1
			if(hitInfo.gameObject.tag == "rock1"){
			ScoreController.rock1Score ();
			ScoreController.HpPlayerFall ();

		}//rock2
			if (hitInfo.gameObject.tag == "rock2"){
			ScoreController.rock2Score ();
			ScoreController.HpPlayerFall ();
		}//item2
			if(hitInfo.gameObject.tag == "item1"){
			Destroy (hitInfo.gameObject);
			ScoreController.item1Score ();
			ScoreController.HpPlayerAdd ();
		}
	}


}