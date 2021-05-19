using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_writer : MonoBehaviour
{
    [HideInInspector]public int dT = 0;
    [HideInInspector]public float cT = 0;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cT += 0.2f; 
        if( cT >= dT && dT<5 ){
            switch(dT){
                case 0:text.text = "P";break;
                case 1:text.text = "PA";break;
                case 2:text.text = "PAU";break;
                case 3:text.text = "PAUS";break;
                case 4:text.text = "PAUSE";break;
            }
            dT++;
        }
    }
}
