using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCoordinates : MonoBehaviour {
    public int x;
    public int z;
    public Renderer rend;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log(this.x);
        Debug.Log(this.z);
        Debug.Log("MouseDown");
        rend = this.transform.gameObject.GetComponent<Renderer>();
        rend.enabled = true;
    }
}
