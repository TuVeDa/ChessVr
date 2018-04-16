using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PieceSelector : MonoBehaviour// required interface when using the OnPointerDown method.
{
    //Do this when the mouse is clicked over the selectable object this script is attached to.
    void OnMouseDown()
    {
        string teamColor = this.tag;
        GameObject[] pieces = GameObject.FindGameObjectsWithTag(teamColor);
        for (int i = 0; i < pieces.Length; i++)
        {
            //no need to set clicked on piece to false, cause were about to set it to true
            Debug.Log(pieces[i]);
            Debug.Log("before " + pieces[i].GetComponent<KingController>().isSelected);
            pieces[i].GetComponent<KingController>().isSelected = false;
            Debug.Log("after " + pieces[i].GetComponent<KingController>().isSelected);
        }
        Debug.Log("color: " + teamColor);
        Debug.Log(this);
        Debug.Log("before " + GetComponent<KingController>().isSelected);
        GetComponent<KingController>().isSelected = true;
        Debug.Log("after " + GetComponent<KingController>().isSelected);        

    }
}