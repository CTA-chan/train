using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de : MonoBehaviour
{
    public static bool parti;
    GameObject paricle;

    // Start is called before the first frame update
    void Start()
    {
        parti = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(parti == false){
            Debug.Log("消したぜ");
            paricle = GameObject.Find("run"); 
            if(paricle){
        
                Destroy(paricle.gameObject);
                parti = true;
            }
        }else{
            Debug.Log("消してないぜ");
        }
    }
}
