﻿using UnityEngine;
using System.Collections;

public class Bulet : MonoBehaviour {
	public CircleCollider2D body;
	public Transform ball;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0.3f,0);
	}
}
