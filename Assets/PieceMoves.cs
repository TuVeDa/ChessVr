using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMoves : MonoBehaviour {
    public List<Vector3> landingTiles;
    private int currentX;
    private int currentZ;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public List<Vector3> CalculateLandingTiles(int currentX, int currentZ) {
        Debug.Log("currentX" + currentX);
        Debug.Log("currentZ" + currentZ);
        Vector3 forward = new Vector3(currentX + 1, 0, currentZ);
        Vector3 forwardRight = new Vector3(currentX + 1, 0, currentZ + 1);
        Vector3 forwardLeft = new Vector3(currentX + 1, 0, currentZ - 1);
        List<Vector3> newLandingTiles = new List<Vector3>();
        newLandingTiles.Add(forward);
        newLandingTiles.Add(forwardRight);
        newLandingTiles.Add(forwardLeft);
        this.landingTiles = newLandingTiles;
        return newLandingTiles;
    }
}
