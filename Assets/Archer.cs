using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Abstract
{
    [SerializeField] private UI ui;
    [SerializeField] private AcceptButton acceptButton;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(126, 142, 184, 47), "Archer"))
        {
            ui.Stats = ("Health: " + Health + "\nDefense: " + Defense + "\nAttack: " + Attack);

            acceptButton.gHealth = Health;
        }
    }
}
