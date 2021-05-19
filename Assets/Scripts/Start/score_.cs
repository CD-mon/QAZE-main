using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_ : MonoBehaviour
{
    [SerializeField]GameObject UI_Score;
    [SerializeField]Text text_hc,text_grate,text_good,text_miss;
    private int v_hc=0,v_gr=0,v_go=0,v_mi=0;
    private bool played_;
    [HideInInspector]public int highcombo,grate,good,miss;
    void Start()
    {
        UI_Score.SetActive(false);
        highcombo = Referee.get_highcombo();
        grate = Referee.get_grate();
        good = Referee.get_good();
        miss = Referee.get_miss();
        played_ = finish.get_played();
    }
    void Update()
    {
        played_ = finish.get_played();
        if(played_){
            UI_Score.SetActive(true);
        }
        if(v_hc<highcombo){
            text_hc.text = ""+v_hc;
            v_hc++;
        }
        if(v_gr<grate){
            text_grate.text = ""+v_gr;
            v_gr++;
        }
        if(v_go<good){
            text_good.text = ""+v_go;
            v_go++;
        }
        if(v_mi<miss){
            text_miss.text = ""+v_mi;
            v_mi++;
        }
    }
}
