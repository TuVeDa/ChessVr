﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {
    public List<GameObject> Tiles = new List<GameObject>();

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame



    public void BuildTiles(Transform board)
    {
        for (int x = -3; x <= 4; x++)
        {
            for (int z = -3; z <= 4; z++)
            {
                GameObject tile = Instantiate(Resources.Load("TilePrefab") as GameObject);
                tile.name = "Tile" + (x+3) + (z+3);
                Tiles.Add(tile);
                tile.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                float newX = (x * 9 + 1);
                float newZ = (z * 9 + 2);
                tile.GetComponent<TileCoordinates>().x = x + 3;
                tile.GetComponent<TileCoordinates>().z = z + 3;
                tile.transform.position = new Vector3(newX, 9, newZ);
                tile.transform.parent = board;
            }
        }
    }

    public void HighlightTiles(List<Vector3> tilePositions)
    {
        Debug.Log("first possible landing position is");
        Debug.Log("x:" + tilePositions[0].x);
        Debug.Log("z:" + tilePositions[0].z);
    }
}
