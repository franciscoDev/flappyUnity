﻿using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour {

	private void OnTriggerEnter2D( Collider2D collider){
	
		if (collider.CompareTag ("Player")) {
			GameController.instance.BirdScore ();
		}
	}
}
