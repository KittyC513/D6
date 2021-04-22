using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepCount : MonoBehaviour
{
    public static int stepCounting = 0;
    Text step;
    // Start is called before the first frame update
    void Start()
    {
        //access the text component of stepCount
        step = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        step.text = "" + stepCounting + "/" ;
    }
}
