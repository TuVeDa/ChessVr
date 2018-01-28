using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKing : MonoBehaviour {

    // Use this for initialization
    private Rigidbody king;
    private Vector3 kingEndPosition;
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void Start () {
        king = GetComponent<Rigidbody>();
        Vector3 kingStartPosition = king.transform.position;
        Vector3 kingEndPostition = kingStartPosition;
        kingEndPostition.z += 8.5f;
        Debug.Log(kingStartPosition);
        Debug.Log(kingEndPostition);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
