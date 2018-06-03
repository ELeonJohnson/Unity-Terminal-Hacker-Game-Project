using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password;

    // Use this for initialization
    void Start ()
    {
        ShowMainMenu();
        OnUserInput("");
       
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Pick a type of player.");
        Terminal.WriteLine("Press 1: All Stars");
        Terminal.WriteLine("Press 2: Stars");
        Terminal.WriteLine("Press 3: Rookies");
        Terminal.WriteLine("Enter Your Selection Below:");
       
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMethod(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    private void RunMainMethod(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "allstars";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "stars";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = "rookies";
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a correct level.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen the level " + level);
        Terminal.WriteLine("Please enter your password:");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Great Job!");
        }
        else
        {
            Terminal.WriteLine("Wrong password, try again.");
        }
    }





}
