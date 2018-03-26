using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour// required interface when using the OnPointerDown method.
{
    //Do this when the mouse is clicked over the selectable object this script is attached to.
    void OnMouseDown()
    {
        Debug.Log("active? " + GetComponent<MoveKing>().isSelected);
        Debug.Log("mousedown");
        GetComponent<MoveKing>().isSelected = true;
        Debug.Log("active? " + GetComponent<MoveKing>().isSelected);
        

    }
}