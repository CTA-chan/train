using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{

    public Text Scor;
    public Text sco;
    string s;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        Scor.text = claer.title;
        s = claer.tit;
        Scor.text = s;
        sco.text = "スコア"+idou.scor;
    }
}
