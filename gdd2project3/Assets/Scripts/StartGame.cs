using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
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
		
		GUILayout.Label("Playing Hide & Seek by Yourself:\n\nRule #1: You must not leave the house until the ritual is completed.\nRule #2: You must turn off every single light in the house while playing.\nRule #3: You must keep quiet while hiding.\nRule #4: Do not continue the ritual for more than one or two hours.\nRule #5: <color=#FF0000>You must burn the doll at the end of the ritual to keep the spirit from coming back...</color>\n\n\n \"I...I don't know what I did wrong...I messed up...I messed up!\nI have to kill it...I'm sure there's a way to kill it!\"");
		
		
		if(GUILayout.Button("Begin", GUILayout.MinHeight(50))){
			//load the red level
			Application.LoadLevel("mainfloor");
		}
		
		
	}
	
	
	void OnGUI(){
		
		//draw the window 
		menuRect = GUILayout.Window (1, menuRect, MenuWindow, "Menu");
		
	}
}
