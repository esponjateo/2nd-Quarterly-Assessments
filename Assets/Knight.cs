using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Abstract
{
    [SerializeField] private UI ui;

    private void Start()
    {
       
        
            ui.Knight = ("Health: " + Health + "\nDefense: " + Defense + "\nAttack: " + Attack);

            
        


    }
}
