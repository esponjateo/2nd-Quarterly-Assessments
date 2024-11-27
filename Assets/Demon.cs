using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Abstract
{
    public string demon = "Health: \nDefense: \nAttack: ";
    public GUIStyle style;

    

    private void OnGUI()
    {
        GUI.Box(new Rect(1197, 381, 199, 201), "");

        GUI.Label(new Rect(1197, 381, 199, 201), demon, style);
    }
    private void Start()
    {


        demon = ("Demon \nHealth: " + Health + "\nDefense: " + Defense + "\nAttack: " + Attack);



    }

}
