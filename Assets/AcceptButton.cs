using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptButton : MonoBehaviour
{
    [SerializeField] private Wizard wizard;
    [SerializeField] private Sword sword;
    [SerializeField] private Archer archer;

    public int gHealth;

    public string ggHealth = "Health: ";

    private void OnGUI()
    {
        if (GUI.Button(new Rect(126, 270, 183, 46), "Accept"))
        {
            ggHealth = "Health: " + gHealth;
        }

        GUI.Label(new Rect(107, 401, 319, 146), ggHealth);

    }


}
