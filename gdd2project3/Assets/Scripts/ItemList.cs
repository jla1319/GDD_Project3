using UnityEngine;
using System.Collections;

public class ItemList : MonoBehaviour {

	private Rect itemRect;
	private int itemWidth = 150;
	private int itemHeight = 120;
	private bool[] found = new bool[5];
	public GUIStyle foundItem;
	public GUIStyle notFound;
	// Use this for initialization
	void Start () {
		itemRect = new Rect(0, 0, itemWidth, itemHeight);
		for(int i = 0; i < found.Length; i++)
		{
			found[i] = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void itemWindow (int windowID)
	{
		if(found[0] == true)
		{
			GUILayout.Label("Matches", foundItem);

		}
		else
		{
			GUILayout.Label("Matches", notFound);
		}
		if(found[1] == true)
		{
			GUILayout.Label("Thread", foundItem);
			
		}
		else
		{
			GUILayout.Label("Thread", notFound);
		}
		if(found[2] == true)
		{
			GUILayout.Label("Salt", foundItem);
			
		}
		else
		{
			GUILayout.Label("Salt", notFound);
		}
		if(found[3] == true)
		{
			GUILayout.Label("Lighter Fluid", foundItem);
			
		}
		else
		{
			GUILayout.Label("Lighter Fluid", notFound);
		}
		if(found[4] == true)
		{
			GUILayout.Label("Knife", foundItem);
			
		}
		else
		{
			GUILayout.Label("Knife", notFound);
		}
	}

	void OnGUI(){
		
		//draw the window 
		itemRect = GUILayout.Window (1, itemRect, itemWindow, "Things to Find...");
	}

	public void ItemFound(string name)
	{
		if(name == "Matches")
		{
			found[0] = true;
		}
		if(name == "Thread")
		{
			found[1] = true;
		}
		if(name == "Salt")
		{
			found[2] = true;
		}
		if(name == "Lighter Fluid")
		{
			found[3] = true;
		}
		if(name == "Knife")
		{
			found[4] = true;
		}
		if(found[0] == true && found[1] == true && found[2] == true && found[3] == true && found[4] == true)
		{
			Application.LoadLevel("victory");
		}
		Debug.Log(found);
	}
}
