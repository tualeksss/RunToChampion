using UnityEngine;
using System.Collections;

public class Playercontroller : MonoBehaviour {
	
	private Rigidbody2D rb2D;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;

	public LayerMask whatIsGround;
	public Animator anim;

	public float jumpForce = 350f;
	bool Jump = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("Ground", false);
			rb2D.AddForce (new Vector2 (0, jumpForce));
			Jump = true;
			GetComponents<AudioSource> () [0].Play ();
		} 
	}
	
	void FixedUpdate () {
		
			grounded = Physics2D.OverlapCircle (groundCheck.position,groundRadius,whatIsGround);
			anim.SetBool ("Ground", grounded);
		}
	}

