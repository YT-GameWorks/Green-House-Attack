using UnityEngine;

namespace GreenHouseAttack.Core
{
    public class PlayerController : MonoBehaviour
    {
        /// <summary>
        /// This handles the player movment and everything
        /// else related to the player.
        /// </summary>

        #region Declarations

        [Header("Character stats")]
        [Range(0.1f, 100f)]
        public float Speed;

        [Range(0.1f, 100f)]
        public float JumpForce;

        [Space]

        [Header("GrounChecking")]
        public bool isGrounded = false;
        public float GroundCheckRadius;
        public LayerMask GroundLayer;

        [Header("References")]
        public Transform GroundChecker;
        [SerializeField]
        private Rigidbody2D rb;


        #endregion

        #region Initialisation

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        #endregion

        #region Movement api

        public void Move(float LeftOrRight)
        {
            float moveby = LeftOrRight * Speed;

            rb.velocity = new Vector2(moveby, rb.velocity.y);
        }

        public void GroundCheck()
        {
            Collider2D collider = Physics2D.OverlapCircle(GroundChecker.position, GroundCheckRadius, GroundLayer);

            if (collider != null)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        }

        public void Jump()
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.y, JumpForce);
            }
        }

        #endregion

    }
}
