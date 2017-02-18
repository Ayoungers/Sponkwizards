using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = Vector2.zero;
		if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        } else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        } else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        } else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }

        if(direction != Vector2.zero)
        {
            gameObject.transform.position = gameObject.transform.position + (Vector3)direction;
        }
	}
}
