using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
	public class GroundManagerObject: MonoBehaviour
	{
		public List<Ground> grounds = new List<Ground>();

		void Start()
		{
			grounds = new List<Ground>();
		}
	}
}
