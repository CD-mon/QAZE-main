using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    [HideInInspector]public static int s_num = 3;
    [SerializeField]GameObject UI_option_s;
    [SerializeField]Text UI_option_nsT;
    private Slider slider_s_num;
    void Start()
    {
        slider_s_num = UI_option_s.GetComponent<Slider>();
        slider_s_num.value = s_num;
        s_num = (int)slider_s_num.value;
    }
    void Update(){
        s_num = (int)slider_s_num.value;
        UI_option_nsT.text = "×" + ns_mgn(s_num);
    }
    private float ns_mgn(int num){
        float mgn = 0;
        switch(num){
            case 0:mgn = 1.75f; break;
            case 1:mgn = 1.5f; break;
            case 2:mgn = 1.25f; break;
            case 3:mgn = 1f; break;
            case 4:mgn = 0.75f; break;
            case 5:mgn = 0.5f; break;
            case 6:mgn = 0.25f; break;
        }
        return mgn;
    }
    public static int get_s_num(){
        return s_num;
    }
    //
}
