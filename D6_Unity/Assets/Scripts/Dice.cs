using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.cyan, Color.grey, Color.yellow };
    public int colourIndex;
    public int faceValue;
    
    public int positionInRow;
    public bool isOnBottomRow;
    bool firstNumber = true;
    bool wasSelected = false;


   


    // Start is called before the first frame update
    void Start()
    {
       
        
       
        //Set the color and face value as random
        colourIndex = Random.Range(0, 6);
        GetComponent<SpriteRenderer>().color = colors[colourIndex]; //pick the color from the Color array
        faceValue = Random.Range(1, 7);

        //apply the face value randomly from the 2d sprites. 
        transform.Find(faceValue.ToString()).gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        //alter the vector3 into a vector2
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        
        //to detect if the mouse in a die's range.
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit)
        {
            Debug.Log("hit" + hit.collider. name);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == ("dices") && firstNumber && wasSelected && Input.GetMouseButtonDown(0))
        {
            lerp();
        }
    }

    void lerp()
    {

    }



}
