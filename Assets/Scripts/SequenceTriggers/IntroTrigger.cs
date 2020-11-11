using UnityEngine;
using UnityEngine.Playables;

namespace GreenHouseAttack.SequenceTriggers
{
	public class IntroTrigger : MonoBehaviour
	{
		public PlayableDirector IntroDirector;

		void Start()
		{
			Invoke("PlayIntro", 1.5f);
		}

		private void PlayIntro()
		{
			IntroDirector.Play();
		}
	}
}
