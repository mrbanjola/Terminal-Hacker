using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;


    // Start is called before the first frame update
    void Start()
    {

        ShowMainMenu();


    }

    void ShowMainMenu()
    {

        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("1. Local Pizzeria");
        Terminal.WriteLine("2. Distant Pizzeria");
        Terminal.WriteLine("3. How much is that hat?");
        Terminal.WriteLine("Enter your selection please:");
    }


    void Start(int level)
    {
        Terminal.WriteLine("Level: " + level.ToString());
    }


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        } else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            Start(1);
            currentScreen = Screen.Password;

        }
        else if (input == "2")
        {
            Start(2);
            currentScreen = Screen.Password;

        }
        else if (input == "3")
        {
            Terminal.WriteLine("A lot, but thats irrelevant.");

        }
        else
        {
            Terminal.WriteLine("Please don't be stupid.");

        }
    }





    // Update is called once per frame 
    void Update()
    {


    }
}