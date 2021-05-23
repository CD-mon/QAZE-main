using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorial_tips : MonoBehaviour
{
    [SerializeField]GameObject t_image1,t_image2,Tutorial,GS_SE;
    [SerializeField]AudioClip se_on,se_back;
    [HideInInspector]public static bool tuto_key=true;
    private AudioSource audio;

    void Start(){
        t_image1.SetActive(true);
        t_image2.SetActive(false);
        audio = GS_SE.GetComponent<AudioSource>();
    }
    public void next_i2(){
        t_image1.SetActive(false);
        t_image2.SetActive(true);
        audio.PlayOneShot(se_on);
    }
    public void back_i1(){
        t_image1.SetActive(true);
        t_image2.SetActive(false);
        audio.PlayOneShot(se_on);
    }
    public void tuto_close(){
        Tutorial.SetActive(false);
        audio.PlayOneShot(se_back);
        tuto_key = false;
    }
    public static bool get_tutokey(){
        return tuto_key;
    }

    void Update()
    {
        if (Tutorial.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (t_image1.activeSelf)
                {
                    this.next_i2();
                }
                else
                {
                    this.tuto_close();
                }
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                this.back_i1();
            }
        }
    }
}
