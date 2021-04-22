using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chainCount : MonoBehaviour
{
    public static int chainCounting = 0;
    Text chain;
    // Start is called before the first frame update
    void Start()
    {
        //access the text component of stepCount
        chain = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        chain.text = "" + chainCounting;
    }
}

