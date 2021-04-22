using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class processCount : MonoBehaviour
{
    public Slider slider;
    public GameObject dice;
    bool stepIncreased = false;

    private void Start()
    {
        
    }

    private void Update()
    {
    
    
    }
    
 
    

    public void SetMaxStep(int totalStep) // set the max step of the game
    {
        slider.maxValue = totalStep;
        slider.value = totalStep;
    }

    public void SetStep(int totalStep) //set the steps relating to the slider component
    {
        slider.value = totalStep;
    }

}
