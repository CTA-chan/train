using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour{

    bool ite;
    float tim;
    
    GameObject I;
    public GameObject K;
    public GameObject S;
    public GameObject C;
    int R;
    bool r;
    GameObject[] Ran = new GameObject[3];

    // Start is called before the first frame update
    void Start(){
        
        Ran[0] = K;
        Ran[1] = S;
        Ran[2] = C;
        r = true;
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
            if(r == true){
                R = Random.Range(0,3);
                r = false;
            }
            I = Ran[R];
            Instantiate(I, new Vector2(Random.Range(-4f,4f),Random.Range(-4f,4f)), Quaternion.identity);
            ite = false;
        }   
    }
}
