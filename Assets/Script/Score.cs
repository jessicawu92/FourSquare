using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	

	int PlayerScore = 0;
	int EnemyScore = 0;

	public void IncreaseScore (int PlayerType) {

		if (PlayerType == 1) {
			PlayerScore++;
		}
		else if (PlayerType == 2) {
			EnemyScore++;
		}
		else {
			Debug.Log ("Error in increasing scores");
		}

	}

	void OnGUI () {

		GUI.Label (new Rect (30,10,300,30), "Player Score: " + PlayerScore.ToString());
		GUI.Label (new Rect (30,35,300,30), "Enemy Score: " + EnemyScore.ToString());
	}
}
