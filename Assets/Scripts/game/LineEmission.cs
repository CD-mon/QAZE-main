using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEmission : MonoBehaviour
{
    public GameObject[] Qlines;
    private MeshRenderer qr,wr,er,rr,tr,yr,ur,ir,or,pr,ar,sr,dr,fr,gr,hr,jr,kr,lr,zr,xr,cr,vr,br,nr,mr,Enter;
    private float[] emTime = new float[27];
    public float emLong;

    void Start()
    {
        GameObject Q = Qlines[0];
        GameObject W = Qlines[1];
        GameObject E = Qlines[2];
        GameObject R = Qlines[3];
        GameObject T = Qlines[4];
        GameObject Y = Qlines[5];
        GameObject U = Qlines[6];
        GameObject I = Qlines[7];
        GameObject O = Qlines[8];
        GameObject P = Qlines[9];
        GameObject A = Qlines[10];
        GameObject S = Qlines[11];
        GameObject D = Qlines[12];
        GameObject F = Qlines[13];
        GameObject G = Qlines[14];
        GameObject H = Qlines[15];
        GameObject J = Qlines[16];
        GameObject K = Qlines[17];
        GameObject L = Qlines[18];
        GameObject Z = Qlines[19];
        GameObject X = Qlines[20];
        GameObject C = Qlines[21];
        GameObject V = Qlines[22];
        GameObject B = Qlines[23];
        GameObject N = Qlines[24];
        GameObject M = Qlines[25];

        GameObject En = Qlines[26];

        qr = Q.GetComponent<MeshRenderer>();
        wr = W.GetComponent<MeshRenderer>();
        er = E.GetComponent<MeshRenderer>();
        rr = R.GetComponent<MeshRenderer>();
        tr = T.GetComponent<MeshRenderer>();
        yr = Y.GetComponent<MeshRenderer>();
        ur = U.GetComponent<MeshRenderer>();
        ir = I.GetComponent<MeshRenderer>();
        or = O.GetComponent<MeshRenderer>();
        pr = P.GetComponent<MeshRenderer>();
        ar = A.GetComponent<MeshRenderer>();
        sr = S.GetComponent<MeshRenderer>();
        dr = D.GetComponent<MeshRenderer>();
        fr = F.GetComponent<MeshRenderer>();
        gr = G.GetComponent<MeshRenderer>();
        hr = H.GetComponent<MeshRenderer>();
        jr = J.GetComponent<MeshRenderer>();
        kr = K.GetComponent<MeshRenderer>();
        lr = L.GetComponent<MeshRenderer>();
        zr = Z.GetComponent<MeshRenderer>();
        xr = X.GetComponent<MeshRenderer>();
        cr = C.GetComponent<MeshRenderer>();
        vr = V.GetComponent<MeshRenderer>();
        br = B.GetComponent<MeshRenderer>();
        nr = N.GetComponent<MeshRenderer>();
        mr = M.GetComponent<MeshRenderer>();

        Enter = En.GetComponent<MeshRenderer>();
    }
 
    void Update()
    {
        if(Input.anyKeyDown){
            if(Input.GetKeyDown(KeyCode.Q))
            {
                qr.material.EnableKeyword("_EMISSION");
                emTime[0] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.W))
            {
                wr.material.EnableKeyword("_EMISSION");
                emTime[1] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.E))
            {
                er.material.EnableKeyword("_EMISSION");
                emTime[2] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                rr.material.EnableKeyword("_EMISSION");
                emTime[3] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.T))
            {
                tr.material.EnableKeyword("_EMISSION");
                emTime[4] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                yr.material.EnableKeyword("_EMISSION");
                emTime[5] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.U))
            {
                ur.material.EnableKeyword("_EMISSION");
                emTime[6] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.I))
            {
                ir.material.EnableKeyword("_EMISSION");
                emTime[7] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.O))
            {
                or.material.EnableKeyword("_EMISSION");
                emTime[8] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.P))
            {
                pr.material.EnableKeyword("_EMISSION");
                emTime[9] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                ar.material.EnableKeyword("_EMISSION");
                emTime[10] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                sr.material.EnableKeyword("_EMISSION");
                emTime[11] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                dr.material.EnableKeyword("_EMISSION");
                emTime[12] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.F))
            {
                fr.material.EnableKeyword("_EMISSION");
                emTime[13] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.G))
            {
                gr.material.EnableKeyword("_EMISSION");
                emTime[14] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.H))
            {
                hr.material.EnableKeyword("_EMISSION");
                emTime[15] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.J))
            {
                jr.material.EnableKeyword("_EMISSION");
                emTime[16] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.K))
            {
                kr.material.EnableKeyword("_EMISSION");
                emTime[17] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.L))
            {
                lr.material.EnableKeyword("_EMISSION");
                emTime[18] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.Z))
            {
                zr.material.EnableKeyword("_EMISSION");
                emTime[19] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.X))
            {
                xr.material.EnableKeyword("_EMISSION");
                emTime[20] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.C))
            {
                cr.material.EnableKeyword("_EMISSION");
                emTime[21] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.V))
            {
                vr.material.EnableKeyword("_EMISSION");
                emTime[22] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.B))
            {
                br.material.EnableKeyword("_EMISSION");
                emTime[23] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.N))
            {
                nr.material.EnableKeyword("_EMISSION");
                emTime[24] = Time.deltaTime*emLong;
            }
            if(Input.GetKeyDown(KeyCode.M))
            {
                mr.material.EnableKeyword("_EMISSION");
                emTime[25] = Time.deltaTime*emLong;
            }
            //Enter
            if(Input.GetKeyDown(KeyCode.Return))
            {
                Enter.material.EnableKeyword("_EMISSION");
                emTime[26] = Time.deltaTime*emLong;
            }
        }
        else{
            if(emTime[0]<=0)qr.material.DisableKeyword("_EMISSION");
            if(emTime[1]<=0)wr.material.DisableKeyword("_EMISSION");
            if(emTime[2]<=0)er.material.DisableKeyword("_EMISSION");
            if(emTime[3]<=0)rr.material.DisableKeyword("_EMISSION");
            if(emTime[4]<=0)tr.material.DisableKeyword("_EMISSION");
            if(emTime[5]<=0)yr.material.DisableKeyword("_EMISSION");
            if(emTime[6]<=0)ur.material.DisableKeyword("_EMISSION");
            if(emTime[7]<=0)ir.material.DisableKeyword("_EMISSION");
            if(emTime[8]<=0)or.material.DisableKeyword("_EMISSION");
            if(emTime[9]<=0)pr.material.DisableKeyword("_EMISSION");
            if(emTime[10]<=0)ar.material.DisableKeyword("_EMISSION");  
            if(emTime[11]<=0)sr.material.DisableKeyword("_EMISSION");  
            if(emTime[12]<=0)dr.material.DisableKeyword("_EMISSION");  
            if(emTime[13]<=0)fr.material.DisableKeyword("_EMISSION");  
            if(emTime[14]<=0)gr.material.DisableKeyword("_EMISSION");  
            if(emTime[15]<=0)hr.material.DisableKeyword("_EMISSION");  
            if(emTime[16]<=0)jr.material.DisableKeyword("_EMISSION");  
            if(emTime[17]<=0)kr.material.DisableKeyword("_EMISSION");  
            if(emTime[18]<=0)lr.material.DisableKeyword("_EMISSION");  
            if(emTime[19]<=0)zr.material.DisableKeyword("_EMISSION");    
            if(emTime[20]<=0)xr.material.DisableKeyword("_EMISSION");    
            if(emTime[21]<=0)cr.material.DisableKeyword("_EMISSION");    
            if(emTime[22]<=0)vr.material.DisableKeyword("_EMISSION");    
            if(emTime[23]<=0)br.material.DisableKeyword("_EMISSION");    
            if(emTime[24]<=0)nr.material.DisableKeyword("_EMISSION");    
            if(emTime[25]<=0)mr.material.DisableKeyword("_EMISSION");
            if(emTime[26]<=0)Enter.material.DisableKeyword("_EMISSION");      
        }
        for(int i = 0;i<27;i++){
            if(emTime[i]>0){
                emTime[i] -=Time.deltaTime;
            }
            else{
                emTime[i] = 0;
            }
        }
    }
}
