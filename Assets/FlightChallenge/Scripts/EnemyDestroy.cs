using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

	// Use this for initialization
	public int health;

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		health--;
		if (health <= 0) {
			Destroy (gameObject);
			Destroy (collision.gameObject);
			ScoreManager.score = ScoreManager.score + 1;
		}
		Debug.Log ("trigger");
	}
}
