using UnityEngine;

public class playerController : MonoBehaviour
{

    int playerSpeed = 5;//�÷��̾� ���ǵ� �⺻��
    Rigidbody2D rd;
    int playerBulletCount = 10;
    int maxSpeed = 5;
    float horizontal;
    float vertical;
    public GameObject PlyerBullet;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }


    void PlayerMove()//�÷��̾� �̵�
    {

        horizontal = Input.GetAxisRaw("Horizontal");//���ι���
        vertical = Input.GetAxisRaw("Vertical");//���ι���

        transform.Translate(new Vector3(horizontal, vertical, 0f).normalized * Time.deltaTime * playerSpeed);//�÷��̾� �̵�
      
        if (Input.GetKeyDown(KeyCode.LeftShift))//����Ʈ �Է½� �����԰��� �ڵ�
        {
            playerSpeed = 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 5;
        }
    }

    void playershot()// ���� 
    {//ź���� z �� �߻�, x�� �Ѿ�(��)�� �߻��� �� ������ �Ѿ��� ��ź�� ������ ������ �� �������� �� cŰ�� ���� �������� �ؾ���
        if (Input.GetKey(KeyCode.Z))//�Ѿ� �߻� 
        {
            
        }
        if (Input.GetKey(KeyCode.X))//�Ѿ� �߻� 
        {
            if (playerBulletCount > 0)
            {

            }
        }
        if (Input.GetKey(KeyCode.C))//������
        {//0.5������ ������
            
        }


    }
}


