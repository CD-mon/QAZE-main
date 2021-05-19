using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ready : MonoBehaviour
{
    public int setLineNo = 0;
    public GameObject Qs,As,Zs,Enter,EQ,EA,EZ,fadein;
    public Text cdText;
    private Animator readyAni;
    private bool[] on = {true,true,true,true,true,true,true,true,true};
    // Update is called once per frame
    public void setLine(int i){
        switch(i){
            case 0:{
                readyAni.SetTrigger("on");
                Qs.SetActive(true);
                Enter.SetActive(true);
                EQ.SetActive(true);
                on[8]=false;
            }break;
            case 1:{
                readyAni.SetTrigger("on");
                As.SetActive(true);
                Enter.SetActive(true);
                EA.SetActive(true);
                on[8]=false;
            }break;
            case 2:{
                readyAni.SetTrigger("on");
                Zs.SetActive(true);
                Enter.SetActive(true);
                EZ.SetActive(true);
                on[8]=false;
            }break;
        }
    }
    void Start(){
        readyAni = cdText.GetComponent<Animator>();
        fadein.SetActive(true);
    }
    void Update()
    {
        float T = Time.timeSinceLevelLoad;
        if(T>=2.2f&&on[8]){
            setLine(setLineNo);
        }
        if(T>=0.5f){
            if(on[0]){
                cdText.text = "R";
                on[0]=false;
            }
        }
         if(T>=0.6f){
            if(on[1]){
                cdText.text = "RE";
                on[1]=false;
            }
        }
         if(T>=0.7f){
            if(on[2]){
                cdText.text = "REA";
                on[2]=false;
            }
        }
         if(T>=0.8f){
            if(on[3]){
                cdText.text = "READ";
                on[3]=false;
            }
        }
         if(T>=0.9f){
            if(on[4]){
                cdText.text = "READY";
                on[4]=false;
            }
        }
         if(T>=1.0f){
            if(on[5]){
                cdText.text = "READY.";
                on[5]=false;
            }
        }
         if(T>=1.1f){
            if(on[6]){
                cdText.text = "READY..";
                on[6]=false;
            }
        }
         if(T>=1.2f){
            if(on[7]){
                cdText.text = "READY...";
                on[7]=false;
            }
        }
    }
}
