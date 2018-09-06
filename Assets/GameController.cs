using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {



    // Use this for initialization
    private void Start()
    {

    }


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




    private void Update()
    {
       
    }

}