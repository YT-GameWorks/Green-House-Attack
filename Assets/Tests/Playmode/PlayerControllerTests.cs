using System.Collections;
using NUnit.Framework;
using UnityEngine;
using Core;

namespace Tests.Playmode
{
	public class PlayerControllerTests
	{
		[UnityTest]
		public IEnumerator CheckJumpForce()
		{
			var GameObject = new GameObject ();
			var Player = GameObject.AddComponent<PlayerController> ();

			yield return new WaitForSeconds (0.5f);

			Assert.AreEqual (Player.JumpForce, 5.7);
		}

		[UnityTest]
		public IEnumerator CheckSpeed()
		{
			var GameObject = new GameObject ();
			var Player = GameObject.AddComponent<PlayerController> ();

			yield return null;

			Assert.AreEqual (Player.Speed, 2.8);
		}
	}
}
