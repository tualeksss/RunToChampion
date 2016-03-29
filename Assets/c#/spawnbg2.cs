using UnityEngine;
using System.Collections;

public class spawnbg2 : MonoBehaviour {

	public Transform shotPrefab;

	void Start () {
		InvokeRepeating ("Spawn", 0.2f, 3.0f); 
	}

	void Spawn () {
		Transform shotTransform = Instantiate (shotPrefab);
		shotTransform.position = transform.position;
	}

}