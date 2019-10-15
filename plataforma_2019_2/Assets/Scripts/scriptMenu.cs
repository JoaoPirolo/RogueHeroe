using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMenu : MonoBehaviour
{
    private void OnGUI()
    {
        const int buttonWidth = 100;
        const int buttonHeight = 50;
        const int buttonWidthe = 100;
        const int buttonHeighte = 50;


        if (GUI.Button(
            new Rect (Screen.width / 2.4f - (buttonWidth / 1),
            (2 * Screen.height / 2.2f) - (buttonWidth / 2),
                    buttonWidth, buttonHeight),
                    "START")){
            Application.LoadLevel("Level 1");
        }
        if(GUI.Button(
            new Rect(Screen.width/1.4f - (buttonWidthe/1),
            (2* Screen.height/2.2f) - (buttonWidthe/2),
            buttonWidthe, buttonHeighte),
            "QUIT"))
        {
            Application.Quit();
        }
    }
}
