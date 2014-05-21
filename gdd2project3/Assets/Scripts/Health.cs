using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100;
	// Use this for initialization
	void Start () {
		InvokeRepeating("AddHealth", 0, 1);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("f"))
		{
			health -=20;
			print (health);
		}
		if(health <= 0)
		{
			CancelInvoke("AddHealth");
			Application.LoadLevel("gameover");
		}
	}
	// This is called once every second
	void AddHealth () {
		health++;
		if(health > 100)
		{
			health = 100;
		}
		print (health);
	}
	public void DealDamage (float damage) {
		health -= damage;
	}
}
