using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setup : MonoBehaviour
{
    [SerializeField]GameObject _Start,Menu,Menu_Play,QAZE,Enter,QAZE_play,play_on,back,Canvas_fade,display_screen,CD_II_Switch,GS_bgm,ui_tutorial,UI_option;

    void Start()
    {
        QAZE.SetActive(true);
        Enter.SetActive(true);
        _Start.SetActive(true);
        Menu.SetActive(false);
        Menu_Play.SetActive(false);
        QAZE_play.SetActive(false);
        //play_on.SetActive(false);
        back.SetActive(false);
        Canvas_fade.SetActive(false);
        display_screen.SetActive(false);
        CD_II_Switch.SetActive(false);
        GS_bgm.SetActive(true);
        ui_tutorial.SetActive(false);
        UI_option.SetActive(false);
    }
}
