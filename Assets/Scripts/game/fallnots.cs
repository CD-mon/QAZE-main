using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallnots : MonoBehaviour
{
    private notes_speed n_s_cs;
    private GameObject GS_ns;
    private float fspeed;
    
    void Start(){
        GS_ns = GameObject.FindWithTag("GS_ns");
        n_s_cs = GS_ns.GetComponent<notes_speed>();
        fspeed = n_s_cs.speed;
    }
    void Update()
    {
        Transform myT = this.transform;
        Vector3 myP = myT.position;
        myP -= new Vector3(0,fspeed*Time.deltaTime,0);
        myT.position = myP;
        
        if(myP.y<=-7.0f){
            Destroy(gameObject);
        }
    } 
}
