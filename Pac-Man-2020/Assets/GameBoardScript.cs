using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameboard : MonoBehaviour {

    private static int boardWidth = 19; 
    private static int boardHeight = 22; 

    public GameObject[,] board = new GameObject[boardWith, boardHeight]; // array that is multidimensional; initalized with board width and board height.

    void Start() {
        Object[] objects = GameObject.FindObjectOfType (tyeof(GameObject)); // object that iterates over each object.

        foreach (GameObject o in objects) { // in the foreach loop, for every object in this object array, assign the object at the current iteration of this variable o. It's a type game object.
            Vector2 pos = o.transform.position; // this is the position. The local position is relative within the game objects. 

            if (o.name != "PacMan" && o.name != "Maze") { // we can to store actual gameboard objects. we don't need to store pacman.
                board [(int)pos.x, (int)pos.y] = o; // at the position we're currently at, we will store o.
            } else {
                Debug.Log ("Found PacMan at: " + pos); // if it finds pacman, it will say hey, there's pacman. 
                }
            }
        }

        void Update () {
            
        }
    }