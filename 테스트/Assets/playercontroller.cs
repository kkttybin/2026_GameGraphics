using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

  public string playerName = "Player";
  public int hp = 100;
  public float moveSpeed = 5f;
  public Vector3 startPosition;
  private Vector2 moveInput;
  public Transform visual;
  public float jumpPower = 8f;
  private Rigidbody2D rb;

    void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    transform.position = startPosition;
    Debug.Log(playerName + " 시작. 체력 " + hp);
    Debug.Log("피격 후 체력 " + (hp - 30));
    Debug.Log("달리기 속도 " + moveSpeed * 2);
    Debug.Log("10 / 4 = " + 10 / 4);
  }

    void OnJump(InputValue value)
  {
    //if (value.isPressed)
    {
      Debug.Log("점프!");
      rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
    }
  }
    void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
    if (moveInput.x > 0)
    {
      visual.localScale = new Vector3(1, 1, 1);
    }
    else if (moveInput.x < 0)
    {
      visual.localScale = new Vector3(-1, 1, 1);
    }
  }




    void Update()
    {
        //Debug.Log("Update");
        transform.Translate(Vector3.right * moveInput.x * moveSpeed * Time.deltaTime);
    }
}
