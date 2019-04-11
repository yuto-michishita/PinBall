using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	private float visiblePosZ = -6.5f;
	private int Score;
	public int sumScore;
	private GameObject gameoverText;
	private GameObject ScoreText;

	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find ("GameOverText");
		this.ScoreText = GameObject.Find ("ScoreText");
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ) {

			this.gameoverText.GetComponent<Text> ().text = "Game Over";

		}
		Score = GameScore (0);
		this.ScoreText.GetComponent<Text> ().text = "Score :"+Score;
	}

	public int GameScore(int score){
		
		sumScore = sumScore + score;
		return sumScore;
	}
}
