using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicleShot : MonoBehaviour
{
    public float speed = 10f;
    //발사될 총알 오브젝트
    public GameObject bullet;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            InvokeRepeating("Shot", 0,0.2f);
            

        }
        if (Input.GetKey(KeyCode.I))
        {
            CancelInvoke();
        }
    }

    void Shot()
    {
        
            //360번 반복
            for (int i = 0; i < 360; i += 13)
            {
                //총알 생성
                GameObject temp = Instantiate(bullet);

                //2초마다 삭제
                Destroy(temp, 4f);

                //총알 생성 위치를 보스 좌표로 한다.
                temp.transform.position = gameObject.transform.position;

                //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
                temp.transform.rotation = Quaternion.Euler(0, 0, i);


            }
      




    }

}