using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour{

    bool ite;
    float tim;

    public GameObject K;
    //public GameObject S;
    
    // Start is called before the first frame update
    void Start(){
        ite = false;
        tim = 15f;
    }

    // Update is called once per frame
    void Update(){


        if(ite == false){
            tim -= Time.deltaTime;
        }
        
        if(tim <= 0){
            ite = true;
            tim = 10f;
        }

        if(ite == true){
            Instantiate(K, new Vector2(Random.Range(-4f,4f),Random.Range(-4f,4f)), Quaternion.identity);
            ite = false;
        }   
    }
}
