using UnityEngine;

public namespace Core
{
	public class CameraFollow : MonoBehaviour
	{
		//TODO: Make smooth.
		public GameObject FollowTarget;

		private void LateUpdate()
		{
			gameObject.transform.localPosition = FollowTarget.transform.position;
		}
	}
}
