using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Referee : MonoBehaviour
{
    private float topT=0.15f , midT=0.10f , justT=0.05f;
    [HideInInspector]public static int combo=0 , grate=0 , good=0 , miss=0 , HighCombo = 0 , nowE=0;
    [SerializeField] Text Judg;
    [SerializeField] GameObject text_grate,text_good,text_miss,SE,ScoreCanvas,GS_geneQAZ;
    [SerializeField] AudioClip se_qaz,se_enterkey;
    private generatorQAZ cs_geneqaz;
    private AudioSource se;
    private Animator scAni;
    public GameObject GS_ns;
    private notes_speed ns_cs;
    
    void Start(){
        ns_cs = GS_ns.GetComponent<notes_speed>();
        reset_score();
        se = SE.GetComponent<AudioSource>();
        se.volume = option_main.get_se_num() / 100f;
        scAni = ScoreCanvas.GetComponent<Animator>();
        cs_geneqaz = GS_geneQAZ.GetComponent<generatorQAZ>();
        JudgTextSwitch(3);
    }
    void Update()
    {
        if(Time.timeSinceLevelLoad>=1.5f){
            if(Input.GetKeyDown(KeyCode.Q)){
            search(0,"Q(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.W)){
            search(1,"W(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.E)){
            search(2,"E(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.R)){
            search(3,"R(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.T)){
            search(4,"T(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            search(5,"Y(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.U)){
            search(6,"U(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.I)){
            search(7,"I(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.O)){
            search(8,"O(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.P)){
            search(9,"P(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.A)){
            search(10,"A(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.S)){
            search(11,"S(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.D)){
            search(12,"D(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.F)){
            search(13,"F(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.G)){
            search(14,"G(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.H)){
            search(15,"H(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.J)){
            search(16,"J(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.K)){
            search(17,"K(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.L)){
            search(18,"L(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.Z)){
            search(19,"Z(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.X)){
            search(20,"X(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.C)){
            search(21,"C(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.V)){
            search(22,"V(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.B)){
            search(23,"B(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.N)){
            search(24,"N(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.M)){
            search(25,"M(Clone)");
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            switch(nowE){
                case 0:search(26,"EnterQ(Clone)");nowE=1;break;
                case 1:search(27,"EnterA(Clone)");nowE=2;break;
                case 2:search(28,"EnterZ(Clone)");nowE=0;break;
            }
        }
        }
    }
    public void search(int Object,string nowKey){
        float nowT = Time.timeSinceLevelLoad;
        int i;
        for(i=0;i<cs_geneqaz.size;i++){
            float insT = cs_geneqaz.insTime[i]+4.0f;
            if( (insT-topT)<=nowT && nowT<=(insT+topT) ){//探索して先に見つかった生成ノーツから判定
                if(cs_geneqaz.insObject[i]==Object&&nowE_match(Object)){//生成オブジェクト番号との照合、及びレーン色の称号
                    cs_geneqaz.insTime[i]=0;
                    judg_2(Object,nowT,insT,nowKey);
                }
            }
        }
    }
    private bool nowE_match(int objectNo){
        int num = 0;
        if( (0<=objectNo&&objectNo<=9) || objectNo==26)num = 0;//q
        else if( (10<=objectNo&&objectNo<=18) || objectNo==27)num = 1;//a
        else if( (19<=objectNo&&objectNo<=25) || objectNo==28)num = 2;//z
        if(nowE==num){
            return true;
        }
        else{
            return false;
        }
    }
    public void judg_2(int Object,float nowT,float insT,string nowKey){
        GameObject notes = GameObject.Find(nowKey);
        //grate
        if( (insT-justT)<=nowT && nowT<=(insT+justT) ){
            JudgTextSwitch(0);
            Destroy(notes);
            combo++;
            grate++;
            if(combo>=HighCombo)HighCombo = combo;
            Judg.text = ""+combo;
            scAni.SetTrigger("on");
            if(Object>=26)se.PlayOneShot(se_enterkey);
            else se.PlayOneShot(se_qaz);
        }
        //good
        else if( (insT-midT)<=nowT&&nowT<(insT-justT) || (insT+justT)<nowT&&nowT<=(insT+midT) ){
            JudgTextSwitch(1);
            Destroy(notes);
            combo++;
            good++;
            if(combo>=HighCombo)HighCombo = combo;
            Judg.text = ""+combo;
            scAni.SetTrigger("on");
            if(Object>=26)se.PlayOneShot(se_enterkey);
            else se.PlayOneShot(se_qaz);
        }
        //miss
        else{
            JudgTextSwitch(2);
            Destroy(notes);
            combo=0;
            miss++;
            Judg.text = "";
        }
    }
    public void JudgTextSwitch(int i){
        switch(i){
            case 0:
                text_grate.SetActive(true);
                text_good.SetActive(false);
                text_miss.SetActive(false);
                break;
            case 1:
                text_grate.SetActive(false);
                text_good.SetActive(true);
                text_miss.SetActive(false);
                break;
            case 2:
                text_grate.SetActive(false);
                text_good.SetActive(false);
                text_miss.SetActive(true);
                break;
            case 3:
                text_grate.SetActive(false);
                text_good.SetActive(false);
                text_miss.SetActive(false);
                break;
        }
    }
    public void combo_0(){
        combo = 0;
    } 
    public void miss_inc(){
        miss++;
    }
    public static int get_highcombo(){
        return HighCombo;
	}
    public static int get_grate(){
        return grate;
	}
    public static int get_good(){
        return good;
	}
    public static int get_miss(){
        return miss;
	}
    public void reset_score(){
        nowE = 0;
        combo = 0;
        HighCombo = 0;
        grate = 0;
        good = 0;
        miss = 0;
    }
}
