using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int level;
    string gamerName;

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu("Player 1");
        OnUserInput("");
       
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello " + greeting);
        Terminal.WriteLine("Pick a type of player.");
        Terminal.WriteLine("Press 1: All Stars");
        Terminal.WriteLine("Press 2: Stars");
        Terminal.WriteLine("Press 3: Rookies");
        Terminal.WriteLine("Enter Your Selection Below:");
       
    }

    void OnUserInput(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "24" || input == "8")
        {
            Terminal.WriteLine("Which kobe do you perfer, 8 or 24?");
        }
        else if (input == "menu")
        {
            ShowMainMenu("Enoch");
        }
        else 
        {
            Terminal.WriteLine("Please choose a correct level.");
        }    
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen the level " + level);
    }





}
