using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int playerSpeed = 5;//�÷��̾� ���ǵ� �⺻��
    Rigidbody2D rid2d;
    int playerBulletCount = 10;
    public GameObject PlyerBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }


    void PlayerMove()//�÷��̾� �̵�
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -playerSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0 ,0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 5;
        }
    }

    void playershot()// ���� ���
    {//�Ѿ��� ZŰ�� �߻��ϸ� CŰ�� ������
        if (Input.GetKey(KeyCode.Z))//�Ѿ� �߻� 
        {
            if (playerBulletCount > 0) 
            {

            }
        }

        

    }
}
