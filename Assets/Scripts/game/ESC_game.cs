using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ESC_game : MonoBehaviour
{
    [SerializeField]GameObject GS_Music,UI_ESC,UI_ESC_Text_;
    private AudioSource bgm;
    private text_writer cs_tw;
    private music cs_music;
    private bool key = true;
    private float currentT;
    void Start(){
        bgm = GS_Music.GetComponent<AudioSource>();
        cs_music = GS_Music.GetComponent<music>();
        cs_tw = UI_ESC_Text_.GetComponent<text_writer>();
        Cursor.visible = false;
    }
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape) ){
            if(key){
                pause();
            }
            else{
                resume();
            }
        }
    }
    public void pause(){
        Time.timeScale = 0;
        cs_tw.cT = 0;
        cs_tw.dT = 0;
        UI_ESC.SetActive(true);
        currentT = bgm.time;
        if(cs_music.on)bgm.Stop();
        key = false;
        Cursor.visible = true;
    }
    public void resume(){
        UI_ESC.SetActive(false);
        Time.timeScale = 1;
        bgm.time = currentT;
        if(cs_music.on)bgm.Play();
        key = true;
        Cursor.visible = false;
    }
    public void to_menu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("QAZE");
    }
    public void restart(){
        Time.timeScale = 1;
        Cursor.visible = false;
        SceneManager.LoadScene("game_demo");
    }
}
