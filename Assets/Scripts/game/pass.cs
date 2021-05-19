using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pass : MonoBehaviour
{
    public GameObject GS_Referee;
    [SerializeField]Text UI_score; 
    private Referee cs_referee;
    void Start(){
        cs_referee = GS_Referee.GetComponent<Referee>();
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="center"){
            cs_referee.JudgTextSwitch(2);//miss
            cs_referee.combo_0();
            cs_referee.miss_inc();
            UI_score.text = "";
            Destroy(col.gameObject);
        }
    }
}
