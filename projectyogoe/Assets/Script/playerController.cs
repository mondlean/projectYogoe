using UnityEngine;

public class playerController : MonoBehaviour
{

    int playerSpeed = 10;//플레이어 스피드 기본값
    Rigidbody2D rd;
    int playerBulletCount = 10;
    float horizontal;
    float vertical;
    public GameObject PlyerBullet;
    public GameObject PlyaerDanmaku;
   
    float bulletInterval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        playershot();
    }


    void PlayerMove()//플레이어 이동
    {

        horizontal = Input.GetAxisRaw("Horizontal");//가로방향
        vertical = Input.GetAxisRaw("Vertical");//세로방향

        transform.Translate(new Vector3(horizontal, vertical, 0f).normalized * Time.deltaTime * playerSpeed);//플레이어 이동
      
        if (Input.GetKeyDown(KeyCode.LeftShift))//쉬프트 입력시 느리게가는 코드
        {
            playerSpeed = 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 5;
        }
    }

    void playershot()// 공격 
    {//탄막은 z 로 발사, x로 총알(붐)을 발사할 수 있으며 총알은 장탄수 제한이 있으며 다 떨어졌을 시 c키를 눌러 재장전을 해야함
        if (Input.GetKeyDown(KeyCode.Z))
        {
         
            
            InvokeRepeating("danmakumade", 0f, bulletInterval);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            
            CancelInvoke("danmakumade"); // InvokeRepeating() 함수 중지
        }
        if (Input.GetKey(KeyCode.X))//총알 발사 
        {
            if (playerBulletCount > 0)
            {
                
            }
        }
        if (Input.GetKey(KeyCode.C))//재장전
        {//0.5초정도 딜레이
            
        }

        
    }

    void danmakumade()
    {
       
        GameObject temp = Instantiate(PlyaerDanmaku);
        temp.transform.position = gameObject.transform.position;

        // 2초마다 삭제
        Destroy(temp, 1f);
        
    }
}


