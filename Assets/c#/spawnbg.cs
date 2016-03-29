using UnityEngine;
using System.Collections;

public class spawnbg : MonoBehaviour {

	public Transform shotPrefab;

	void Start () {
		InvokeRepeating ("Spawn", 0.1f, 4.0f); 
	}

	void Spawn () {
		Transform shotTransform = Instantiate (shotPrefab);
		shotTransform.position = transform.position;
	}

}
