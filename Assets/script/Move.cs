using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Transform tank;
	private int speed;
	// Use this for initialization
	void Start () {
		speed =0;
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(tank.position.x);

		if(tank.position.x>8){
			if(Input.acceleration.x<0){
				transform.Translate(Input.acceleration.x, 0,0);
			}
		}else if(tank.position.x<-8){
			if(Input.acceleration.x>0){
				transform.Translate(Input.acceleration.x, 0,0);
			}
		}else{
			transform.Translate(Input.acceleration.x, 0,0);
		}
	}
}
