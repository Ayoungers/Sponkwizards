using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<GameObject> units;
    public GameObject cursor;
    private int currentUnit;
    private enum state
    {
        Select,
        Move
    }
    private state currentState;

    void Start()
    {
        currentState = state.Select;
        currentUnit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case state.Select:
                Select();
                break;
            case state.Move:
                Move();
                break;
        }
    }

    void Select()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentUnit--;
            if (currentUnit < 0)
            {
                currentUnit = units.Count - 1;
            }
            cursor.transform.position = units[currentUnit].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentUnit++;
            if (currentUnit >= units.Count)
            {
                currentUnit = 0;
            }
            cursor.transform.position = units[currentUnit].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = state.Move;
            cursor.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void Move()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        } 
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = state.Select;
            cursor.transform.position = units[currentUnit].transform.position;
            cursor.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (direction != Vector2.zero)
        {
            units[currentUnit].transform.position = units[currentUnit].transform.position + (Vector3)direction;
        }

    }
}