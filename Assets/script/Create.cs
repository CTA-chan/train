using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour{

    GameObject[] box = new GameObject[8];

    public GameObject spot1,spot2,spot3,spot4,spot5,spot6,spot7,spot8;
    public GameObject dolly;

    bool cre;
    float tim = 10f;

    int d;
    // Start is called before the first frame update
    void Start(){
        box[0] = spot1;
        box[1] = spot2;
        box[2] = spot3;
        box[3] = spot4;
        box[4] = spot5;
        box[5] = spot6;
        box[6] = spot7;
        box[7] = spot8;
        cre = false;
    }

    // Update is called once per frame
    void Update(){
        d = Random.Range(0,7);
        GameObject b = box[d];
        
        if(cre == false){
            tim -= Time.deltaTime;
        }
        
        if(tim <= 0){
            cre = true;
            tim = Random.Range(1f,5f)+5f;;
        }

        if(cre == true){
            Instantiate(dolly, b.transform.position, Quaternion.identity);
            cre = false;
        }   
    }
}

