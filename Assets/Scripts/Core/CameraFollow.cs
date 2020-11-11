using UnityEngine;

namespace GreenHouseAttack.Core
{
	public class CameraFollow : MonoBehaviour
	{
		public Transform Target;

		public float smoothSpeed;
		public Vector3 offset;

		void LateUpdate()
		{
			Vector3 desiredPosition = Target.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;

			transform.LookAt(Target);
		}
	}
}
