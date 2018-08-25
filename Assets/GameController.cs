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
        for (int x = -3; x <= 4; x++)
        {
            for (int z = -3; z <= 4; z++)
            {
                GameObject tile = Instantiate(Resources.Load("TilePrefab") as GameObject);
                tile.name = "Tile";
                Tiles.Add(tile);
                var collider = tile.AddComponent<BoxCollider>();
                tile.GetComponent<Renderer>().material.color = new Color(0,0,0,0);
                float newX = (x * 9 + 1);
                float newZ = (z * 9 + 2);
                tile.transform.position = new Vector3(newX, 9, newZ);
                tile.transform.parent = board;
            }
        }
    }


    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Tile")
            {
                foreach (GameObject tile in Tiles)
                {
                    tile.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                }
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }

}