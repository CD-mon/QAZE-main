using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_start : MonoBehaviour
{
    [SerializeField]GameObject fade,QAZE_play,ui_start_tuto,GS_CDswitch,GS_SE;
    [SerializeField]AudioClip se_start;
    private Animator ani1,ani2,ani3;
    private AudioSource se;
    private IEnumerator game_start(){
        fade.SetActive(true);
        ani1 = QAZE_play.GetComponent<Animator>();
        ani2 = ui_start_tuto.GetComponent<Animator>();
        ani3 = GS_CDswitch.GetComponent<Animator>();
        se = GS_SE.GetComponent<AudioSource>();
        ani1.SetTrigger("start");
        ani2.SetTrigger("start");
        ani3.SetTrigger("start");
        se.PlayOneShot(se_start);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("game_demo");
    }
    public void tutorial_Start(){
        StartCoroutine ("game_start");
    }
    
}
