using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicleShot : MonoBehaviour
{
    public float speed = 10f;
    //�߻�� �Ѿ� ������Ʈ
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
        
            //360�� �ݺ�
            for (int i = 0; i < 360; i += 13)
            {
                //�Ѿ� ����
                GameObject temp = Instantiate(bullet);

                //2�ʸ��� ����
                Destroy(temp, 4f);

                //�Ѿ� ���� ��ġ�� ���� ��ǥ�� �Ѵ�.
                temp.transform.position = gameObject.transform.position;

                //Z�� ���� ���ؾ� ȸ���� �̷�����Ƿ�, Z�� i�� �����Ѵ�.
                temp.transform.rotation = Quaternion.Euler(0, 0, i);


            }
      




    }

}