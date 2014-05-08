using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject Ball;
	BallController ballController;

	// Use this for initialization
	void Start () {
		ballController = Ball.GetComponent<BallController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( ballController.TowardsPlayer == 1) {
			if (Ball.transform.position.x > transform.position.x){
				transform.position = new Vector3 (transform.position.x + 0.2f, transform.position.y, transform.position.z);
			}
			if (Ball.transform.position.x < transform.position.x){
				transform.position = new Vector3 (transform.position.x - 0.2f, transform.position.y, transform.position.z);
			}
		}
		else {
			if (0 > transform.position.x){
				transform.position = new Vector3 (transform.position.x + 0.2f, transform.position.y, transform.position.z);
			}
			if (0 < transform.position.x){
				transform.position = new Vector3 (transform.position.x - 0.2f, transform.position.y, transform.position.z);
			}
		}

	}
}
