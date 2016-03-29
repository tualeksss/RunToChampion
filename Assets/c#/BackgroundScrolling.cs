using UnityEngine;
using System.Collections;

public class BackgroundScrolling : MonoBehaviour {

	public Vector2 speed = new Vector2(5,5);
	public Vector2 direction = new Vector2(-1,0);
	public bool isLinkToCamera = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
		movement *= Time.deltaTime;
		transform.Translate (movement);
		if(isLinkToCamera){
			Camera.main.transform.Translate (movement);
		}
	}
}
