using UnityEngine;

namespace GreenHouseAttack.Dialouge
{
	[System.Serializable]
	public class Dialouge
	{
		public string name;

		[TextArea(3, 10)]
		public string[] sentences;
	}
}