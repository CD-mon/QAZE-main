using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cmode_point : MonoBehaviour
{
    [SerializeField]GameObject display_i,Cmode_d,t_coverC;
    private Animator ani;

    public void Cmode_p_enter(){
        Cmode_d.SetActive(true);
        display_i.GetComponent<Image>().color = new Color(0,126.0f/255.0f,126.0f/255.0f,1.0f);
        ani=t_coverC.GetComponent<Animator>();
        ani.SetTrigger("cm_point");
    }
    public void Cmode_p_exit(){
        Cmode_d.SetActive(false);
        display_i.GetComponent<Image>().color = new Color(31.0f/255.0f,31.0f/255.0f,31.0f/255.0f,1.0f);
        ani=t_coverC.GetComponent<Animator>();
        ani.SetTrigger("exit");
    }
}
