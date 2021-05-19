using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    [HideInInspector]public bool on = false, did = true;
    [SerializeField]GameObject fade;
    public float musicLong_seconds;

    void Update()
    {
        if(Time.timeSinceLevelLoad>=4.0f){
            on = true;
        }
        if(on){
            if(did){
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                did = false;
            }
        }
        if(Time.timeSinceLevelLoad>=(musicLong_seconds+3.0f)){
            fade.SetActive(true);
        }
    }
}
