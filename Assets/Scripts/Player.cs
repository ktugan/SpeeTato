using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    public Vector2 jumpForce = new Vector2(0, 300);
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            rg.velocity = Vector2.zero;
            rg.AddForce(jumpForce);
        }
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}