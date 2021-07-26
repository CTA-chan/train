using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyy : MonoBehaviour{

    public Sprite spriteUe;
    public Sprite spriteSita;
    public Sprite spriteHidari;
    public Sprite spriteMigi;
    SpriteRenderer s ;

    // Start is called before the first frame update
    void Start()
    {
        s = gameObject.GetComponent<SpriteRenderer>();
        s.sprite = spriteSita;
    }

    // Update is called once per frame
    void Update(){
        if(idou.zyou > 0){
            s.sprite = spriteUe;
        }else{
            if(idou.zyou < 0){
            s.sprite = spriteSita;
            }else{
                if(idou.sayu > 0){
                s.sprite = spriteMigi;
                }else{
                    if(idou.sayu < 0){
                    s.sprite = spriteSita;
                    }   
                }     
            }
        }
    }
}
