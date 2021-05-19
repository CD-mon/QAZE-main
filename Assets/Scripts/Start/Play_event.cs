using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_event : MonoBehaviour
{
    [SerializeField]GameObject display_screen,screen,t_coverP,Play,CreateMode,Option,display,Canvas_tips,play_on,QAZE,QAZE_play,Menu_Play,GS_cdswitch,GS_bgm,GS_SE,ui_tutorial;
    [SerializeField]AudioClip se_select,se_on;

    private AudioSource audio;
    public void Start(){
        audio = GS_SE.GetComponent<AudioSource>();
    }
    private Animator ani;
    
    public void Play_p_enter(){
        display_screen.SetActive(true);
        screen.SetActive(false);
        ani=t_coverP.GetComponent<Animator>();
        ani.SetTrigger("play_point");
        audio.PlayOneShot(se_select);
    }
    public void Play_p_exit(){
        display_screen.SetActive(false);
        screen.SetActive(true);
        ani=t_coverP.GetComponent<Animator>();
        ani.SetTrigger("exit");
    }
    public void Play_p_click(){
        display_screen.SetActive(false);
        Play.SetActive(false);
        CreateMode.SetActive(false);
        Option.SetActive(false);
        display.SetActive(false);
        Canvas_tips.SetActive(false);
        QAZE.SetActive(false);
        QAZE_play.SetActive(true);
        Menu_Play.SetActive(true);
        GS_cdswitch.SetActive(true);
        GS_bgm.SetActive(false);
        audio.PlayOneShot(se_on);
        if(tutorial_tips.get_tutokey()){
            ui_tutorial.SetActive(true);
        }
    }
}