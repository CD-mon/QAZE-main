using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CD_image : MonoBehaviour
{
    //private int n_EleC = 0;
    //[SerializeField]int elementC;
    [SerializeField]GameObject CD_main;
    [SerializeField]Sprite[] sprite;
    [SerializeField]AudioClip[] intro;
    private SpriteRenderer spriteR;
    private AudioSource audio;
    public int number = 0;

    void Start(){
        spriteR = CD_main.GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
        spriteR.sprite = sprite[number];
    }
    void Update(){
        audio.clip = intro[number];
    }
}
