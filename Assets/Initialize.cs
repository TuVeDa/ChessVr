using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour {


    // Use this for initialization

    public void SwitchActivePlayer()
    {
        PlayerController[] players = GetComponentsInChildren<PlayerController>();
        foreach (PlayerController player in players)
        {
            if (player.GetComponentsInChildren<PieceController>().Length == 0)
            {
                Debug.Log("Game Over!!");
            }
            player.isActive = !player.isActive;
        }
    }
}