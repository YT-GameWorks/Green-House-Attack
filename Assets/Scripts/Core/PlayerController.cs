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

		//button movement
		public bool moveLeft = false;
		public bool moveRight = false;
		public float horizontalMove;


        #endregion

        #region Initialisation

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

		void Update()
		{
			Move();
		}

        #endregion

        #region Movement api

        public void Move()
        {
	        if (moveLeft)
	        {
		        horizontalMove = Speed;
	        }
	        else if (moveRight)
	        {
		        horizontalMove -= Speed;
	        }
	        else
	        {
		        horizontalMove = 0;
	        }
        }

		void FixedUpdate()
		{
			rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
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
