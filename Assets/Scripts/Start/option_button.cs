using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option_button : MonoBehaviour
{
    public GameObject UI_option,GS_SE;
    [SerializeField]AudioClip se_on;
    private AudioSource audio;
    public void back(){
        audio = GS_SE.GetComponent<AudioSource>();
        audio.PlayOneShot(se_on);
        UI_option.SetActive(false);
    }
}
