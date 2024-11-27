using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Calculation : Abstract
{
    [SerializeField] UI ui;
    [SerializeField] AcceptButton acceptButton;
    [SerializeField] Demon DDemon;

    public GUIStyle style;
   


    private int Damage = 27;

    public string newHealth = "Health: ";

    public string Lost = "";


    private void OnGUI()
    {


        if (GUI.Button(new Rect(594, 401, 319, 146), "Damage: " + Damage))
        {
            acceptButton.gHealth -= Damage;
            acceptButton.ggHealth = "Health: " + acceptButton.gHealth;

            DDemon.Health -= Damage;
            DDemon.demon = ("Demon \nHealth: " + DDemon.Health + "\nDefense: " + DDemon.Defense + "\nAttack: " + DDemon.Attack);




            if (acceptButton.gHealth < 0)
            {
                Debug.Log("asasd");
                acceptButton.gHealth = 0;
                acceptButton.ggHealth = "Health: " + acceptButton.gHealth;

                Lost = "You Lost";


            } 
            if (DDemon.Health < 0)
            {
                DDemon.Health = 0;
                DDemon.demon = ("Demon \nHealth: " + DDemon.Health + "\nDefense: " + DDemon.Defense + "\nAttack: " + DDemon.Attack);

                Lost = "You Won";
            }

        }




        GUI.Box(new Rect(476, 610, 456, 97), "");
        GUI.Label(new Rect(476, 610, 456, 97), Lost, style);

        GUI.Label(new Rect(107,401, 319, 146), acceptButton.ggHealth);



    }



}
