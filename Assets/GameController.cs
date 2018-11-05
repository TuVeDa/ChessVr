using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public string winner = "";


    // Use this for initialization
    private void Start()
    {
    }


    public void SwitchActivePlayer()
    {
        PlayerController[] players = GetComponentsInChildren<PlayerController>();
        foreach (PlayerController player in players)
        {
            player.isActive = !player.isActive;
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), winner);
    }

    public void EndGame(string w)
    {
        this.winner = "Winner is " + w;
        PieceController[] pieces = GetComponentsInChildren<PieceController>();
        foreach (PieceController piece in pieces)
        {
            piece.RemovePiece();
        }
    }



    private void Update()
    {
       
    }

}