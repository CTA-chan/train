using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCreate : MonoBehaviour{

    public GameObject paricle;

    int par;
    // Start is called before the first frame update
    void Start()
    {
        par = 0;
    }

    // Update is called once per frame
    void Update(){
        GameObject pae = GameObject.Find("run");

        if(idou.speed == true){
            if(par <= 1){
                Instantiate(paricle, this.transform.position, Quaternion.identity);
                par += 1;
            }
        }else{
            Destroy(pae);
            par = 0;
        }
    }
}
