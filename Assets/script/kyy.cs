using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyy : MonoBehaviour{

    public Sprite spriteMae;
    public Sprite spriteAto;
    SpriteRenderer s ;

    // Start is called before the first frame update
    void Start()
    {
        s = gameObject.GetComponent<SpriteRenderer>();
        s.sprite = spriteMae;
    }

    // Update is called once per frame
    void Update(){
        if(idou.sayu == 0 && idou.zyou == 0){
            s.sprite = spriteAto;
        }else{
            s.sprite = spriteMae;
        }
    }
}
