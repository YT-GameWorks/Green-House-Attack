using System.Collections;
using NUnit.Framework;
using UnityEngine;
using Core;

namespace Tests.Playmode
{
	public class CameraFollowTest
	{
		[UnityTest]
		public IEnumerator CheckCameraFollow()
		{
			var Gameobject = new GameObject();
			var Camera = Gameobject.AddComponent<CameraFollow>();

			var player = Gameobject.AddComponent<PlayerController>();

			Assert.AreEqual(Camera.transform.localPosition, player.transform.localPosition);

			yield return new WaitForSeconds(0.01f);
		}
	}
}