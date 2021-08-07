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
    private AudioSource gamebgm_demo;
    public int number = 0;

    void Start(){
        spriteR = CD_main.GetComponent<SpriteRenderer>();
        gamebgm_demo = GetComponent<AudioSource>();
        gamebgm_demo.volume = option_main.get_gamebgm_num() / 100f;
        spriteR.sprite = sprite[number];
    }
    void Update(){
        gamebgm_demo.clip = intro[number];
    }
}
