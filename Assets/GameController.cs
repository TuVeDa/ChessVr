using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public List<GameObject> Tiles = new List<GameObject>();


    // Use this for initialization
    private void Start()
    {
        this.BuildTiles(this.gameObject.transform.GetChild(2));
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

    void BuildTiles(Transform board)
    {
        Debug.Log(board.position);
        for (int x = 1; x <= 8; x++)
        {
            for (int z = 1; z <= 8; z++)
            {
                GameObject tile = new GameObject();
                tile.name = "Tile";
                tile.transform.position = new Vector3(x, 0, z);
                Tiles.Add(tile);
            }
        }
    }
}