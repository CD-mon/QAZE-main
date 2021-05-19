using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Option_point : MonoBehaviour
{
    [SerializeField]GameObject display_i,Option_d,t_coverO,UI_Option;
    private Animator ani;

    public void Option_p_enter(){
        Option_d.SetActive(true);
        display_i.GetComponent<Image>().color = new Color(126.0f/255.0f,126.0f/255.0f,0,1.0f);
        ani=t_coverO.GetComponent<Animator>();
        ani.SetTrigger("option_point");
    }
    public void Option_p_exit(){
        Option_d.SetActive(false);
        display_i.GetComponent<Image>().color =  new Color(31.0f/255.0f,31.0f/255.0f,31.0f/255.0f,1.0f);
        ani=t_coverO.GetComponent<Animator>();
        ani.SetTrigger("exit");
    }
    public void Option_p_click(){
        UI_Option.SetActive(true);
    }
}
