﻿using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log (collider);
		Projectile missile = collider.gameObject.GetComponent<Projectile> ();
		if (missile) {
			Debug.Log ("Hit by a proj");
		}
	}
}
