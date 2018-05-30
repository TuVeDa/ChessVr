﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PieceController : MonoBehaviour // required interface when using the OnPointerDown method.
{

    // Use this for initialization
	private float moveSpeed;
    public bool isSelected;

    void Start () {
		moveSpeed = 9;
        isSelected = false;
	}
	
	// Update is called once per frame
	void Update () { 
        if (isSelected && this.transform.parent.GetComponent<PlayerController>().isActive)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
                MovePiece(Vector3.forward);

            if (Input.GetKeyUp(KeyCode.DownArrow))
                MovePiece(Vector3.back);

            if (Input.GetKeyUp(KeyCode.LeftArrow))
                MovePiece(Vector3.left);

            if (Input.GetKeyUp(KeyCode.RightArrow))
                MovePiece(Vector3.right);
        }

    }

    void MovePiece(Vector3 move)
    {
        transform.Translate(move * moveSpeed);
        int x = Mathf.RoundToInt(move.x);
        int z = Mathf.RoundToInt(move.z);
        this.GetComponent<TileController>().SetCoordinates(x, z);
        this.transform.parent.transform.parent.GetComponent<Initialize>().SwitchActivePlayer();
    }

    void OnMouseDown()
    {
        if (this.transform.parent.GetComponent<PlayerController>().isActive)
        {
            PieceController[] pieceControllers = this.transform.parent.transform.parent.GetComponentsInChildren<PieceController>();
            foreach(PieceController pieceController in pieceControllers)
            {
                pieceController.isSelected = false;
            }
            this.isSelected = true;
        }
    }
    public void RemovePiece()
    {
        Destroy(this.gameObject);
    }
}