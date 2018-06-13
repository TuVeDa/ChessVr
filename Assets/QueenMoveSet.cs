using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenMoveSet : MonoBehaviour {
    List<Vector3> MoveSet = new List<Vector3>();

    // Use this for initialization
    void Start () {
        for (int x = 1; x <= 8; x++)
        {
            MoveSet.Add(new Vector3(x, 0, x));
            MoveSet.Add(new Vector3(x, 0, 0));
            MoveSet.Add(new Vector3(0, 0, x));
            MoveSet.Add(new Vector3(-x, 0, -x));
            MoveSet.Add(new Vector3(-x, 0, 0));
            MoveSet.Add(new Vector3(0, 0, -x));
        }
        Debug.Log(MoveSet);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
