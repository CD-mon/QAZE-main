using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_play : MonoBehaviour
{
    [SerializeField]GameObject vc_play,Menu;
    public void PlayButton(){
        vc_play.SetActive(true);
        Menu.SetActive(false);
    }
}
