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
        else//�Ѿ� ���� ��
        {
            //�������ؾ��Ѵٴ� ǥ��
        }
        
    }

    public void rerode()
    {
        playerBulletCount = 7;
        spriteRenderer.sprite = bulletsprite[playerBulletCount];
    }

}
