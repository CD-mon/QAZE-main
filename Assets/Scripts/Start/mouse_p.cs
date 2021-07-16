using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_p : MonoBehaviour
{
    // Start is called before the first frame update
    private float T;
    void Start()
    {
        T = 0;
    }

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;
        if(T >= 1.0f)
            this.gameObject.SetActive(false);
    }
}
