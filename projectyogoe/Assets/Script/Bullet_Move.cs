using UnityEngine;

public class Bullet_Move : MonoBehaviour
{

    public float speed = 10f;

    private void Start()
    {
        //�������κ��� 2�� �� ����

    }

    private void Update()
    {
        //�ι�° �Ķ���Ϳ� Space.World�� �������ν� Rotation�� ���� ���� ������ ������
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self);
        

    }
}