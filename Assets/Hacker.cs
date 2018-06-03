using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game Configuration Data
    string[] levelOnePasswords = { "steph", "lebron", "anthony", "james", "kyrie", "russel" };
    string[] levelTwoPasswords = { "draymond", "kevin", "rondo", "chris", "gordon","carmelo" };
    string[] levelThreePasswords = { "donovan", "jayson", "ben", "kyle", "dennis", "lauri" };


    // Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password;
    const string menuHint = "Enter 'menu' to return to menu screen";

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
        Terminal.WriteLine("Enter 1: All Stars");
        Terminal.WriteLine("Enter 2: Stars");
        Terminal.WriteLine("Enter 3: Rookies");
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

    void RunMainMethod(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");

        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else
        {
            ShowMainMenu();
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                int randomLevelOneIndex = Random.Range(0, levelOnePasswords.Length);
                password = levelOnePasswords[randomLevelOneIndex];
                break;
            case 2:
                int randomLevelTwoIndex = Random.Range(0, levelTwoPasswords.Length);
                password = levelTwoPasswords[randomLevelTwoIndex];
                break;
            case 3:
                int randomLevelThreeIndex = Random.Range(0, levelThreePasswords.Length);
                password = levelThreePasswords[randomLevelThreeIndex];
                break;
            default:
                Debug.LogError("Invalid Level Number");
                break;
        }
        Terminal.WriteLine("Enter the player's name: " + password.Anagram());
        Terminal.WriteLine(menuHint);
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("You guessed a All Star");
                Terminal.WriteLine(menuHint);
                break;
            case 2:
                Terminal.WriteLine("You guessed a Star");
                Terminal.WriteLine(menuHint);
                break;
            case 3:
                Terminal.WriteLine("You guessed a Rookie");
                Terminal.WriteLine(menuHint);
                break;
        }
        
    }
}
