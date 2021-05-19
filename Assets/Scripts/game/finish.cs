using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private float time;
    [SerializeField]GameObject GS_Music;
    private music cs_music;
    public static bool played = false;
    void Start(){
        cs_music = GS_Music.GetComponent<music>();
        played = false;
    }
    void Update()
    {
        time = Time.timeSinceLevelLoad;
        if( time >= (cs_music.musicLong_seconds+5f) ){
            played = true;
            Cursor.visible = true;
            SceneManager.LoadScene("QAZE");
        }
    }
    public static bool get_played(){
        return played;
    }
    public static void set_p_false(){
        played = false;
    }
}
