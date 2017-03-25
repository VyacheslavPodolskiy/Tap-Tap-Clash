using UnityEngine;

namespace Assets.Scripts
{
	public class Ground
	{
		public GameObject place { get; set; }

		public Ground(int x, int y, GameObject place)
		{
			this.place = place;

			place.GetComponent<GroundInfo>().x = x;
			place.GetComponent<GroundInfo>().y = y;
		}
	}
}
