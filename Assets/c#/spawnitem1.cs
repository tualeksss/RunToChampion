using UnityEngine;
using System.Collections;

public class spawnitem1 : MonoBehaviour {
	public Transform shotPrefab;

	void Start () {
		InvokeRepeating ("Spawn",1.0f, Random.Range(5.0f,10.0f)); 
	}

	void Spawn () {
		Transform shotTransform = Instantiate (shotPrefab);
		shotTransform.position = transform.position;
	}

}
