using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_Rigidbody;

    [SerializeField]
    private float m_Speed;

    //private bool _wannaJump = false;

    //private bool _isGrounded = false;

   // [SerializeField]
    //private float m_JumpForce;

    //[SerializeField]
    //private LayerMask m_GroundMask;

   // private bool _canDoubleJump = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




        /*_isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, m_GroundMask);

        if (_isGrounded)
        {
            _canDoubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (_isGrounded || _canDoubleJump))
        {
            _wannaJump = true;

            if (!_isGrounded)
            {
                _canDoubleJump = false;
            }
        }*/
    }

    private void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        float movement2 = Input.GetAxis("Vertical");

        m_Rigidbody.velocity = new Vector2(movement * m_Speed, m_Rigidbody.velocity.y);
        m_Rigidbody.velocity = new Vector2(movement2 * m_Speed, m_Rigidbody.velocity.x);



        /*if (_wannaJump)
        {
            _wannaJump = false;

            m_Rigidbody.velocity = new Vector2(m_Rigidbody.velocity.x, 0);
            m_Rigidbody.AddForce(new Vector2(0, m_JumpForce), ForceMode2D.Impulse);
        }*/
    }

    
}
