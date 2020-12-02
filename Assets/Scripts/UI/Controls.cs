using GreenHouseAttack.Core;
using UnityEngine;

namespace GreenHouseAttack.UI
{
    public class Controls : MonoBehaviour, IPossibleControls
    {
        public PlayerController playerController;

        public void PointerUpLeft()
        {
            playerController.moveLeft = false;
        }

        public void PointerDownLeft()
        {
            playerController.moveLeft = true;
        }

        public void PointerUpRight()
        {
            //FIXME MoveRight goes way too fast.
            playerController.moveRight = false;
        }

        public void PointerDownRight()
        {
            playerController.moveRight = true;
        }

        public void OnJump()
        {
            playerController.Jump();
        }

    }
}
