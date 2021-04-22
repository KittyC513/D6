using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSpot : MonoBehaviour
{
    int currentDis = 0;
    public float speed;
    public GameObject[] squareSpot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInSquare();
    }

    void moveInSquare()
    {
        if (Vector3.Distance(squareSpot[currentDis].transform.position, transform.position) < 1)
        {
            currentDis++;
            if (currentDis >= squareSpot.Length)
            {
                currentDis = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, squareSpot[currentDis].transform.position, Time.deltaTime * speed);
    }
}
