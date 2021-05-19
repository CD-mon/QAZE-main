using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generatorQAZ : MonoBehaviour
{
    //詳細
    public int size;
    public int[] insObject;
    public float[] insTime;
    private bool[] insDid;//ノーツが二個以上でることを防ぐ
    //初期設定
    [HideInInspector]public int insCount=0;
    public GameObject[] qaze = new GameObject[29];
    public GameObject GS_ns;
    private notes_speed ns_cs;

    public void qazGene(int i){
        switch(i){
            case 0:Instantiate(qaze[0],new Vector3(-3.427f,5.5f,-1f),Quaternion.identity);
            break;
            case 1:Instantiate(qaze[1],new Vector3(-2.71f,5.5f,-1f),Quaternion.identity);
            break;
            case 2:Instantiate(qaze[2],new Vector3(-2.05f,5.5f,-1f),Quaternion.identity);
            break;
            case 3:Instantiate(qaze[3],new Vector3(-1.39f,5.5f,-1f),Quaternion.identity);
            break;
            case 4:Instantiate(qaze[4],new Vector3(-0.71f,5.5f,-1f),Quaternion.identity);
            break;
            case 5:Instantiate(qaze[5],new Vector3(-0.06f,5.5f,-1f),Quaternion.identity);
            break;
            case 6:Instantiate(qaze[6],new Vector3(0.61f,5.5f,-1f),Quaternion.identity);
            break;
            case 7:Instantiate(qaze[7],new Vector3(1.26f,5.5f,-1f),Quaternion.identity);
            break;
            case 8:Instantiate(qaze[8],new Vector3(1.93f,5.5f,-1f),Quaternion.identity);
            break;
            case 9:Instantiate(qaze[9],new Vector3(2.58f,5.5f,-1f),Quaternion.identity);
            break;
            case 10:Instantiate(qaze[10],new Vector3(-3.39f,5.5f,-1f),Quaternion.identity);
            break;
            case 11:Instantiate(qaze[11],new Vector3(-2.62f,5.5f,-1f),Quaternion.identity);
            break;
            case 12:Instantiate(qaze[12],new Vector3(-1.85f,5.5f,-1f),Quaternion.identity);
            break;
            case 13:Instantiate(qaze[13],new Vector3(-1.07f,5.5f,-1f),Quaternion.identity);
            break;
            case 14:Instantiate(qaze[14],new Vector3(-0.3f,5.5f,-1f),Quaternion.identity);
            break;
            case 15:Instantiate(qaze[15],new Vector3(0.47f,5.5f,-1f),Quaternion.identity);
            break;
            case 16:Instantiate(qaze[16],new Vector3(1.24f,5.5f,-1f),Quaternion.identity);
            break;
            case 17:Instantiate(qaze[17],new Vector3(2.04f,5.5f,-1f),Quaternion.identity);
            break;
            case 18:Instantiate(qaze[18],new Vector3(2.82f,5.5f,-1f),Quaternion.identity);
            break;
            case 19:Instantiate(qaze[19],new Vector3(-3.29f,5.5f,-1f),Quaternion.identity);
            break;
            case 20:Instantiate(qaze[20],new Vector3(-2.31f,5.5f,-1f),Quaternion.identity);
            break;
            case 21:Instantiate(qaze[21],new Vector3(-1.3f,5.5f,-1f),Quaternion.identity);
            break;
            case 22:Instantiate(qaze[22],new Vector3(-0.29f,5.5f,-1f),Quaternion.identity);
            break;
            case 23:Instantiate(qaze[23],new Vector3(0.71f,5.5f,-1f),Quaternion.identity);
            break;
            case 24:Instantiate(qaze[24],new Vector3(1.72f,5.5f,-1f),Quaternion.identity);
            break;
            case 25:Instantiate(qaze[25],new Vector3(2.7f,5.5f,-1f),Quaternion.identity);
            break;
            case 26:Instantiate(qaze[26],new Vector3(3.87f,5.5f,-1f),Quaternion.identity);
            break;
            case 27:Instantiate(qaze[27],new Vector3(3.87f,5.5f,-1f),Quaternion.identity);
            break;
            case 28:Instantiate(qaze[28],new Vector3(3.87f,5.5f,-1f),Quaternion.identity);
            break;
        }
    }
    
    void Start()
    {
        ns_cs = GS_ns.GetComponent<notes_speed>();
        insDid = new bool[size];
        for(int i=0;i<size;i++){
            insDid[i] = true;
        }
    } 
    void Update()
    {
        if((insTime[insCount]-ns_cs.notes_s+4.0f)<=Time.timeSinceLevelLoad&&insDid[insCount]){
            qazGene(insObject[insCount]);
            insDid[insCount] = false;
            if(insCount<(size-1)){
                insCount++;
            }
        }
    }
}