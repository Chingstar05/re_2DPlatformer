
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private float originalSpeed;
    private float boostTimer = 0f;
    private bool isBoosted = false;

    private float originalJumpForce;
    private float jumpBoostTimer = 0f;
    private bool isJumpBoosted = false;

    float score;

    

    private void Start()
    {
        originalSpeed = moveSpeed;

      
        originalJumpForce = jumpForce;
    }


    private Rigidbody2D rb;
    public bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        score = 1000f;
    }



    private void Update()
    {
        // 이동 처리
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (moveInput < 0)
            transform.localScale = new Vector3(-3f, 3f, 1f);
        if (moveInput > 0)
            transform.localScale = new Vector3(3f, 3f, 1f);

        // 바닥 체크
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // 점프 처리
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        score  -= Time.deltaTime;
        // 스피드 부스트 타이머
        if (isBoosted)
        {
            boostTimer -= Time.deltaTime;
            if (boostTimer <= 0f)
            {
                moveSpeed = originalSpeed;
                isBoosted = false;
                Debug.Log("스피드 부스트 종료!");
            }
        }

        // 점프 강화 시간 체크
        if (isJumpBoosted)
        {
            jumpBoostTimer -= Time.deltaTime;
            if (jumpBoostTimer <= 0f)
            {
                jumpForce = originalJumpForce;
                isJumpBoosted = false;
                Debug.Log("점프력 강화 종료");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collision.CompareTag("Finish"))
        {
            HighScore.TrySet(SceneManager.GetActiveScene().buildIndex, (int)score);

            collision.GetComponent<LevelObject>().MoveToNextLevel();
        }

        if(collision.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void ActivateSpeedBoost(float amount, float duration)
    {
        moveSpeed = originalSpeed * amount;
        boostTimer = duration;
        isBoosted = true;
        Debug.Log("스피드 부스트 시작!");
    }

    public void ActivateJumpBoost(float multiplier, float duration)
    {
        jumpForce = originalJumpForce * multiplier;
        jumpBoostTimer = duration;
        isJumpBoosted = true;
        Debug.Log("점프력 강화됨!");
    }

   


    // Start is called before the first frame update


    // Update is called once per frame

}
