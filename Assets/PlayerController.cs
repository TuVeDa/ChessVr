using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool isActive;
    public string inputText;
    private int x;
    private int z;

    void Start()
    {
    }

    void Update()
    {
        foreach (char c in Input.inputString)
        {
            inputText += c;
            Debug.Log(inputText);
        }
        if(inputText.Length == 2)
        {
            Debug.Log("longer than 2 ");
            x = inputText[0];
            z = inputText[1];
            PieceController[] pieces = this.transform.GetComponentsInChildren<PieceController>();

            foreach (PieceController piece in pieces)
            {
                if (piece.isSelected)
                {
                    Debug.Log(piece);
                }
            }
        }
    }
}
