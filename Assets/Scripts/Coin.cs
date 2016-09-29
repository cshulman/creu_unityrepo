﻿using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			//function so can keep track of all coins caught
			other.GetComponent<ScoreKeeper>().GotCoin ();
			Destroy(gameObject);
		}
	}		
}
