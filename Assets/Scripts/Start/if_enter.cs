using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_enter : MonoBehaviour
{
    [SerializeField] GameObject _Start,Menu,enter,GS_SE,UI_Score,mouse_p;
    [SerializeField] AudioClip se_entry,se_on;
    private AudioSource audio;
    private bool played_,b1,b2;
    void Start(){
        audio = GS_SE.GetComponent<AudioSource>();
        played_ = finish.get_played();
        b1 = true;
        b2 = true;
    }
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Return)||Input.GetMouseButtonDown(0))
        {
            if(!played_&&b1){
                _Start.SetActive(false);
                Menu.SetActive(true);
                mouse_p.SetActive(true);
                enter.SetActive(false);
                audio.PlayOneShot(se_entry);
                b1 = false;
            }
            if(played_&&b2){
                ui_score_off();
                b2 = false;
            }
        }
    }

    public void ui_score_off(){
        audio.PlayOneShot(se_on);
        UI_Score.SetActive(false);
        finish.set_p_false();
        played_ = finish.get_played();
    }
}
