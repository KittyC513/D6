using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] topSlots = new GameObject[5]; 
    public GameObject[] bottomSlots = new GameObject[5]; 
    public GameObject DicePrefab; 

   
    Dice[] topRow = new Dice[5]; //set the top as five spot in specific position 
    Dice[] bottomRow = new Dice[5]; //set the bottom as five spot in specific position



    

    // Start is called before the first frame update
    void Start()
    {
        
        // spawn the dice in top and bottom rows. 
        for (int i = 0; i < topRow.Length; i++)
        {
            
            topRow[i] = Instantiate(DicePrefab, topSlots[i].transform.position,Quaternion.identity).GetComponent<Dice>();
            bottomRow[i] = Instantiate(DicePrefab, bottomSlots[i].transform.position, Quaternion.identity).GetComponent<Dice>();

            //set the boolean condition, if the dice is in the bottom row. 
            topRow[i].isOnBottomRow = false;
            bottomRow[i].isOnBottomRow = true;

            topRow[i].positionInRow = i;
            bottomRow[i].positionInRow = i;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
