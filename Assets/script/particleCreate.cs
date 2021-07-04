using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCreate : MonoBehaviour{

    public GameObject paricle;

    bool par;
    // Start is called before the first frame update
    void Start()
    {
        par = true;
    }

    // Update is called once per frame
    void Update(){
        GameObject pae = GameObject.Find("run");

        if(idou.speed == true){
            if(par == true){
                Instantiate(paricle, this.transform.position, Quaternion.identity);
                par = false;
            }
        }else{
            Destroy(pae);
            par = true;
        }
    }
}
