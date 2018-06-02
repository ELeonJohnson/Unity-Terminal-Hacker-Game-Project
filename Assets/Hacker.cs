using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu("Enoch");  
    }

    void ShowMainMenu(string userInput)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello " + userInput);
        Terminal.WriteLine("Pick a type of player.");
        Terminal.WriteLine("Press 1: All Stars");
        Terminal.WriteLine("Press 2: Stars");
        Terminal.WriteLine("Press 3: Rookies");
        Terminal.WriteLine("Enter Your Selection Below: ");
    }





    // Update is called once per frame
    void Update () {
		
	}
}
