using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulleCount : MonoBehaviour
{
    public Sprite[] bulletsprite = new Sprite[8];
    int playerBulletCount = 7;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer  = GetComponent<SpriteRenderer>();
       spriteRenderer.sprite =  bulletsprite[7]; 
    } 


    
    public void bulletfire()
    {
        if (playerBulletCount > 0)
        {
            playerBulletCount--;
            spriteRenderer.sprite = bulletsprite[playerBulletCount];

        }
        else//총알 없을 때
        {
            //재장전해야한다는 표시
        }
        
    }

    public void rerode()
    {
        playerBulletCount = 7;
        spriteRenderer.sprite = bulletsprite[playerBulletCount];
    }

}
