using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESC : MonoBehaviour
{
    [SerializeField]GameObject esc,GS_BGM;
    private AudioHighPassFilter bgm_filter;
    void Start(){
        bgm_filter = GS_BGM.GetComponent<AudioHighPassFilter>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(esc.activeSelf){
                esc.SetActive(false);
                bgm_filter.enabled = false;
            }
            else{
                esc.SetActive(true);
                bgm_filter.enabled = true;
            }
        }
    }
    public void YES_on(){
        Application.Quit();
    }
    public void NO_on(){
        esc.SetActive(false);
        bgm_filter.enabled = false;
    }
}
//test
//add comment�iMoet42�j
//add coment second time(moet42)

