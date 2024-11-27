using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    public GUIStyle Style;
    public GUIStyle current;
    public GUIStyle currentStyle;
    public Vector2 Position;
    public Vector2 Size;

    public string Stats = "Health: \nDefense: \nAttack: ";
    public string Knight = "Health: \nDefense: \nAttack: ";
    public string Demon = "Health: \nDefense: \nAttack: ";
    public string Current = "Health: ";


    private void OnGUI()
    {

        GUI.Box(new Rect(Position, Size), "");

        GUI.Label(new Rect(53, 35, 184, 47), "Characters");

        GUI.Box(new Rect(20, 10, 1137, 577), "");

        GUI.Box(new Rect(20, 336, 1136, 12), "");

        GUI.Box(new Rect(515, 53, 361, 249), "");

        GUI.Label(new Rect(515, 53, 361, 249), Stats, Style);

        GUI.Box(new Rect(107, 401, 319, 146), "");

        GUI.Label(new Rect(107, 401, 319, 146), Current);

        GUI.Box(new Rect(1197, 13, 199, 201), "");

        GUI.Label(new Rect(1197, 13, 199, 201), Knight, current);

        GUI.Label(new Rect(1197, 13, 199, 42), "Knight", currentStyle);

        




    }

}
