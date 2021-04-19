using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] topSlots = new GameObject[5];
    public GameObject[] bottomSlots = new GameObject[5];
    public GameObject[] DicePrefab = new GameObject[5];
   
    Dice[] topRow = new Dice[5];
    Dice[] bottomRow = new Dice[5];
    Dice currentDie;


    

    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < topRow.Length; i++)
        {
            topRow[i] = Instantiate(DicePrefab[i], topSlots[i].transform.position,Quaternion.identity).GetComponent<Dice>();
            bottomRow[i] = Instantiate(DicePrefab[i], bottomSlots[i].transform.position, Quaternion.identity).GetComponent<Dice>();

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
