using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	
	private Rect menuRect;
	private int menuWidth = 320;
	private int menuHeight = 150;
	
	
	void Start()
	{
		//define the rectangle area for the window
		menuRect = new Rect( Screen.width/2-175, Screen.height/4, menuWidth, menuHeight);
	}
	
	// a "window" - helps modularize GUI code 
	//each window requires a unique ID number
	void MenuWindow (int windowID)
	{
		
		GUILayout.Label("Insert creepypasta text here + GAME OVER");
		
		
		if(GUILayout.Button("Back to the start", GUILayout.MinHeight(50))){
			//load the red level
			Application.LoadLevel("mainmenu");
		}
		
		
	}
	
	
	void OnGUI(){
		
		//draw the window 
		menuRect = GUILayout.Window (1, menuRect, MenuWindow, "Game Over!");
		
	}
}