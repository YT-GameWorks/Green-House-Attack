using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GreenHouseAttack.Dialouge
{
	public class DialougeManager : MonoBehaviour
	{
		public TextMeshProUGUI nameText;
		public TextMeshProUGUI dialougeText;

		public Animator animator;

		private Queue<string> sentences;

		private void Start()
		{
			sentences = new Queue<string>();
		}

		public void StartDialouge(Dialouge dialouge)
		{
			animator.SetBool("isOpen", true);

			nameText.text = dialouge.name;

			sentences.Clear();

			foreach (string sentence in dialouge.sentences)
			{
				sentences.Enqueue(sentence);
			}

			DisplayNextSentence();
		}

		public void DisplayNextSentence()
		{
			if (sentences.Count == 0)
			{
				EndDialouge();
				return;
			}

			string sentence = sentences.Dequeue();
			StartCoroutine(TypeSentence(sentence));
		}

		IEnumerator TypeSentence(string sentence)
		{
			dialougeText.text = "";

			foreach (char letter in sentence.ToCharArray())
			{
				dialougeText.text += letter;
				yield return null;
			}
		}

		private void EndDialouge()
		{
			animator.SetBool("isOpen", false);
		}

	}
}
