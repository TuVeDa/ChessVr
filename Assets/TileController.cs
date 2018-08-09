using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {
    public int x;
    public int z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetCoordinates(int xOffset, int zOffset)
    {
        Debug.Log("setting coords");
        int newX = this.x + xOffset;
        int newZ = this.z + zOffset;
        this.DetectCollision(newX, newZ);
        this.x = newX;
        this.z = newZ;
        Debug.Log(this.x);
        Debug.Log(this.z);
    }

    void DetectCollision(int newX, int newZ)
    {
        TileController[] tiles = this.transform.parent.transform.parent.GetComponentsInChildren<TileController>();

        foreach (TileController tile in tiles)
        {
            if(tile.x == newX && tile.z == newZ)
            {
                Debug.Log("collision!!!!");
                tile.gameObject.GetComponent<PieceController>().RemovePiece();
            }
        }
    }
}
