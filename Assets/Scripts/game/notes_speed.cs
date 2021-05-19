using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_speed : MonoBehaviour
{
    private int speed_num;
    [HideInInspector]public float speed,notes_s;
    private float notes_m = 9.5f;
    void Start()
    {
        speed_num = Option.get_s_num();
    }

    void Update()
    {
        switch_speednum(speed_num);
    }
    public void switch_speednum(int num){
        switch(num){
            case 0:speed = 12.667f;notes_s = 0.75f;break;
            case 1:speed = 9.5f;   notes_s = 1f;   break;
            case 2:speed = 7.6f;   notes_s = 1.25f;break;
            case 3:speed = 6.333f; notes_s = 1.5f; break;
            case 4:speed = 5.429f; notes_s = 1.75f;break;
            case 5:speed = 4.75f;  notes_s = 2f;   break;
            case 6:speed = 4.222f; notes_s = 2.25f;break;
        }
    } 
}
