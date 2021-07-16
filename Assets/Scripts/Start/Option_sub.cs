using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    [HideInInspector]public static int s_num = 3,bgm_num = 65,se_num = 40;
    [SerializeField]GameObject UI_option_s,UI_option_bgm,UI_option_se,GS_bgm,GS_se;
    [SerializeField]Text UI_option_nsT,UI_option_bgmT,UI_option_seT;
    private Slider slider_s_num,slider_bgm,slider_se;
    private AudioSource bgm,se;
    void Start()
    {
        slider_s_num = UI_option_s.GetComponent<Slider>();
        slider_bgm = UI_option_bgm.GetComponent<Slider>();
        slider_se = UI_option_se.GetComponent<Slider>();
        bgm = GS_bgm.GetComponent<AudioSource>();
        se = GS_se.GetComponent<AudioSource>();
        slider_s_num.value = s_num;
        slider_bgm.value = bgm_num;
        slider_se.value = se_num;
        s_num = (int)slider_s_num.value;
        bgm_num = (int)slider_bgm.value;
        se_num = (int)slider_se.value;
    }
    void Update(){
        s_num = (int)slider_s_num.value;
        bgm_num = (int)slider_bgm.value;
        se_num = (int)slider_se.value;
        UI_option_nsT.text = "×" + ns_mgn(s_num);
        UI_option_bgmT.text = "" + bgm_num;
        UI_option_seT.text = "" + se_num;
        bgm.volume = bgm_num / 100f;
        se.volume = se_num / 100f;
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
}
