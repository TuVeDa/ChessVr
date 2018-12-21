using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public string winner = "";


    // Use this for initialization
    private void Start()
    {
        TileController tileBuilder = GetComponentInChildren<TileController>();
        tileBuilder.BuildTiles(tileBuilder.transform);
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
        int offset_x = Screen.width / 2 - 50;
        int offset_y = Screen.height / 2 - 10;

        GUI.Label(new Rect(offset_x, offset_y, 100, 20), winner);
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