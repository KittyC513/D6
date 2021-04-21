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

    // Start is called before the first frame update
    void Start()
    {
        colourIndex = Random.Range(0, 6);
        GetComponent<SpriteRenderer>().color = colors[colourIndex];
        faceValue = Random.Range(1, 7);

        transform.Find(faceValue.ToString()).gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
