﻿using UnityEngine;
using System.Collections;

public class EvilMushroomDangerArea : MonoBehaviour {
	private Mario mario;
	private EvilMushroom evilMushroom;

	// Use this for initialization
	void Start () {
		this.mario = GameObject.Find("Mario").GetComponent<Mario> ();
		this.evilMushroom = this.GetComponentInParent<EvilMushroom>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (this.evilMushroom.isAlive) {
			if (collider.gameObject.tag == "Player") {
				this.mario.Damage();
			}
		}
	}
}