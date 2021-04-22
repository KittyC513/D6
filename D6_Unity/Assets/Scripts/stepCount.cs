using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepCount : MonoBehaviour
{
    public Slider slider;

   
    
    // Start is called before the first frame update
    void Start()
    {


    }

    public void SetMaxStep(int steps) // set the max value of life bar
    {
        slider.maxValue = steps;
        slider.value = steps;
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    void SetStep(int steps) // set the life bar relating the slider component
    {
        slider.value = steps;
    }
}
