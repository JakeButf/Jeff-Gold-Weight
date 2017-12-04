﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Mole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerHealthManager>().DamagePlayer(1);
        }
        if(other.name == "throwGold(Clone)")
        {
            Destroy(this.gameObject);
        }

    }
}
