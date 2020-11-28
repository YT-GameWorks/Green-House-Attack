using GreenHouseAttack.Core;
using UnityEngine;
using UnityEngine.UI;

namespace GreenHouseAttack.UI
{
    public class Controls : MonoBehaviour
    {
        public Button test;
        public PlayerController playerController;

        void Update()
        {
            //Ground check every frame.
            playerController.GroundCheck();
        }

        public void OnMoveLeft()
        {
            //Move the player on the y axis by -1.
           playerController.Move(-1f);
            playerController.Move(0);
        }

        public void OnMoveRight()
        {
            //Move the player on the y axis 1.
            playerController.Move(1f);
        }

        public void OnJump()
        {
            //Jump the player when jump button is pressed.
            playerController.Jump();
        }
    }
}
