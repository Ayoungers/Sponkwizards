using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public List<Attack> attacks = new List<Attack>();

	// Use this for initialization
	void Start () {
        attacks.Add(new StandardAttack());
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Move (Vector3 direction)
    {
        gameObject.transform.position += direction;
    }
}
