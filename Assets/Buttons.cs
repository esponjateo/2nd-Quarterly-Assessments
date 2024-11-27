using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    Abstract abstract1;

    private int Damage = 27;

    private void OnGUI()
    {
      

        if (GUI.Button(new Rect(570, 423, 270, 87), "Damage 27"))
        {
            if (abstract1.Health > 0)
            {
                abstract1.Health -= Damage;
            }

            else if (abstract1.Health < 0)
            {
                abstract1.Health = 0;
            }
            


        }
    }


}
