using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {
	new public string name;


	// Use this for initialization
	void Start () {
		Debug.Log("I am an object!");
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("First Person Controller");
		Vector3 playerLocation = player.transform.position;
		Vector3 itemLocation = this.transform.position;
		float totalDistance = Mathf.Abs(playerLocation.x - itemLocation.x) + (Mathf.Abs(playerLocation.y - itemLocation.y) - 2) + Mathf.Abs(playerLocation.z - itemLocation.z);
		if(totalDistance <= 3)
		{
			Debug.Log(this.name + "has been picked up!");
			DestroyObject();

		}
	
	}

	void DestroyObject(){
		Destroy(this.gameObject);
	}

}
