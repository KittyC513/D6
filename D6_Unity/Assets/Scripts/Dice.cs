using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Dice : MonoBehaviour
{
    public int maxStep = 50;
    public int currentStep;
    public stepCount sct;
    private Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.cyan, Color.grey, Color.yellow };
    public int colourIndex;
    public int faceValue;
    
    public int positionInRow;
    public bool isOnBottomRow;

    public GameObject processCount;
    public GameObject gameManager;
    bool firstNumber = true;

    public Vector2 endPosition;
    public Vector2 startPosition;
    public float timeStartedLerping;
    public float lerpTime;
    bool shouldLerp = false;

    public AudioClip[] clips;
    private AudioSource ads;
    bool stepIncreased;


    private void StartLerping()
    {
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }




        // Start is called before the first frame update
        void Start()
    {

        StartLerping();
        gameManager = GameObject.Find("GameManager");
        

        ads = FindObjectOfType<AudioSource>();


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
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //alter the vector3 into a vector2
        //Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        //to detect if the mouse in a die's range.
        //RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        //if (hit)
        // {

        //}
    }

    private void OnMouseDown()
    {
        //when it's the first number to select and the lerp is available, the dice will move to check point. 
        if (firstNumber && shouldLerp)
        {
           transform.position = Lerp(startPosition, endPosition, timeStartedLerping, lerpTime);
           ads.Play(); // play clip

           firstNumber = false;
            IncreaseStep();
            stepIncreased = false;

        }
    }

    //lerp function
    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 3)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }

    void IncreaseStep()
    {
        stepIncreased = true;
    }









}
