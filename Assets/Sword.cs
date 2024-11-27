using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Abstract
{
    [SerializeField] private UI ui;

    [SerializeField] private AcceptButton acceptButton;


    private void OnGUI()
    {
        if (GUI.Button(new Rect(126, 79, 184, 47), "Sword Man"))
        {
            ui.Stats = ("Health: " + Health + "\nDefense: " + Defense + "\nAttack: " + Attack);
            
            acceptButton.gHealth = Health;
        }

        
    }
}
