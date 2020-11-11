using UnityEngine;

namespace GreenHouseAttack.Core
{
	public class CameraFollow : MonoBehaviour
	{
		//TODO: Make smooth.
		public Transform FollowTarget;

		private void LateUpdate()
		{
			Vector3 PlayerX = new Vector3();
			PlayerX.x = FollowTarget.position.x;
			gameObject.transform.position = PlayerX;


			Vector3 PlayerY = new Vector3();
			PlayerY.y = FollowTarget.position.y;
			gameObject.transform.position = PlayerY;
		}
	}
}
