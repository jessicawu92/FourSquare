using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	int Invert;
	public int TowardsPlayer = 1;
	
	// Use this for initialization
	void Start () {
		Invert = 1;
		TowardsPlayer = 1;
		rigidbody.velocity = new Vector3 (10.0f, 0.0f, -5.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < -10.5f) {
			GameObject.Find ("Main Camera").GetComponent<Score>().IncreaseScore(2);

			//Enemy lost
			Start();
			transform.position = Vector3.zero;
		}
		if (transform.position.z > 10.5f) {
			GameObject.Find ("Main Camera").GetComponent<Score>().IncreaseScore(1);
			//Player lost
			Start();
			transform.position = Vector3.zero;
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.name == "wall") {
			Invert = Invert * -1;
			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, 5.0f * TowardsPlayer);
		}
		else if (collision.gameObject.name == "Player") {
			TowardsPlayer = 1;
			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, 5.0f);
		}
		else if (collision.gameObject.name == "Enemy") {
			TowardsPlayer = -1;
			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, -5.0f);
		}
	}
}
