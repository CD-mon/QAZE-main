using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PB_event : MonoBehaviour
{
    [SerializeField]GameObject display_screen,Play,CreateMode,Option,display,Canvas_tips,play_on,QAZE_play,back,Text_play,Canvas,Menu_Play,GS_cdswitch,GS_bgm,GS_SE;
    [SerializeField]AudioClip se_back;
    private AudioSource se;
    public void Start(){
        se = GS_SE.GetComponent<AudioSource>();
    }
    public void PB_p_enter(){
        back.SetActive(true);
        Text_play.SetActive(false);
    }
    public void PB_p_exit(){
        back.SetActive(false);
        Text_play.SetActive(true);
    }
    public void PB_p_click(){
        /*
        GameObject P_clone = (GameObject)Instantiate(Play);
        P_clone.transform.SetParent(Canvas.transform,true);
        */
        Play.SetActive(true);
        display_screen.SetActive(true);
        CreateMode.SetActive(true);
        Option.SetActive(true);
        display.SetActive(true);
        Canvas_tips.SetActive(true);
        Menu_Play.SetActive(false);
        QAZE_play.SetActive(false);
        GS_cdswitch.SetActive(false);
        GS_bgm.SetActive(true);
        se.PlayOneShot(se_back);
    }
}
