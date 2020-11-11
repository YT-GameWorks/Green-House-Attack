using UnityEngine;

namespace GreenHouseAttack.Dialouge
{
	public class DialougeTrigger : MonoBehaviour
	{
		public Dialouge dialouge;

		public void TriggerDialouge ()
		{
			FindObjectOfType<DialougeManager>().StartDialouge(dialouge);
		}
	}
}