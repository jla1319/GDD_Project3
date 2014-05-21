using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class GameManager : MonoBehaviour {

	public List<GameObject> WayPoints;
	
	GameObject enemy;
	GameObject player;

	public GameObject EnemyPrefab;
	public GameObject PlayerPrefab;
		
	public float timer = 10.0f;

	// Use this for initialization
	void Start () {
		WayPoints = new List<GameObject> ();
		//find the way points placed in the world
		findWayPoints();
		//make the player object connect with target
		player = (GameObject)PlayerPrefab;

		//enemy = (GameObject)EnemyPrefab;
		Vector3 pos = new Vector3(0,0,0);

		Debug.Log("game has started");

		//make the doll here instead of in already in the environment itself

		pos = new Vector3(-7,6,-74);
		enemy = (GameObject)GameObject.Instantiate(EnemyPrefab,pos,Quaternion.identity);
		enemy.GetComponent<Steer> ().Player = player.gameObject;
		Debug.Log(enemy);
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > 0){
			timer -= Time.deltaTime;
			///Debug.Log(timer);
			enemy.GetComponent<Steer> ().notMoving = true;
		} else {
			enemy.GetComponent<Steer> ().notMoving = false;
			//Debug.Log("ready or not here I come!");
		}
	
	}
	
	void findWayPoints()
	{	
		for (int i = 0; i < 28; i++)
		{
			WayPoints.Add(GameObject.Find("WayPoint"+i));
		}
	}
}
