using UnityEngine;
using System.Collections;

public class DealDamage : MonoBehaviour {

	Health hp;

	// Use this for initialization
	void Start () {
		hp = GetComponent<Health>();
		print (hp);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("First Person Controller");
		GameObject enemy = GameObject.Find ("Enemy-new(Clone)");
		Vector3 playerLocation = player.transform.position;
		Vector3 enemyLocation = enemy.transform.position;
		float totalDistance = Mathf.Abs(playerLocation.x - enemyLocation.x) + (Mathf.Abs(playerLocation.y - enemyLocation.y) - 2) + Mathf.Abs(playerLocation.z - enemyLocation.z);
		if(totalDistance <= 5)
		{
			//print ("damage!");
			hp.DealDamage((5f - totalDistance) / 3.15f);
		}
	}
}
