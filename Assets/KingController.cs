using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KingController : MonoBehaviour // required interface when using the OnPointerDown method.
{

    // Use this for initialization
	private float moveSpeed;
    public bool isSelected;

    void Start () {
		moveSpeed = 9;
        isSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isSelected && this.transform.parent.GetComponent<PlayerController>().isActive)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
                MovePiece(Vector3.forward);

            if (Input.GetKeyUp(KeyCode.DownArrow))
                MovePiece(Vector3.back);

            if (Input.GetKeyUp(KeyCode.LeftArrow))
                MovePiece(Vector3.left);

            if (Input.GetKeyUp(KeyCode.RightArrow))
                MovePiece(Vector3.right);

            if (Input.GetKeyUp(KeyCode.W))
                transform.Translate((Vector3.forward + Vector3.left) * moveSpeed);

            if (Input.GetKeyUp(KeyCode.S))
                transform.Translate((Vector3.back + Vector3.right) * moveSpeed);

            if (Input.GetKeyUp(KeyCode.A))
                transform.Translate((Vector3.left + Vector3.back) * moveSpeed);

            if (Input.GetKeyUp(KeyCode.D))
                transform.Translate((Vector3.right + Vector3.forward) * moveSpeed);
        }

    }

    void MovePiece(Vector3 move)
    {
        transform.Translate(move * moveSpeed);
        this.transform.parent.transform.parent.GetComponent<Initialize>().SwitchActivePlayer();
    }

    void OnMouseDown()
    {
        if (this.transform.parent.GetComponent<PlayerController>().isActive)
        {
            Debug.Log(this.transform.parent.transform.parent.GetComponentsInChildren<KingController>().Length);
            KingController[] pieceControllers = this.transform.parent.transform.parent.GetComponentsInChildren<KingController>();
            foreach(KingController pieceController in pieceControllers)
            {
                pieceController.isSelected = false;
            }
            this.isSelected = true;
        }
    }
}
