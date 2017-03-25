using UnityEngine;

namespace Assets.Scripts
{
	public class GroundInfo : MonoBehaviour
	{
		public int x;
		public int y;

		private Vector3 downPosition;
		private Vector3 upPosition;
		private bool isUp = false;
		private bool isDown = true;

		void OnMouseDown()
		{
			if (isDown)
			{
				var grounds = GameObject.FindGameObjectsWithTag("Ground");

				foreach (var item in grounds)
				{
					item.GetComponent<GroundInfo>().MoveDown();
				}

				MoveUp();
			}
		}

		private void MoveUp()
		{
			if (isDown)
			{
				downPosition = transform.position;
				upPosition = new Vector3(downPosition.x, downPosition.y + 0.3f, downPosition.z);

				transform.position = Vector3.Lerp(transform.position, upPosition, 0.3f);

				isUp = true;
				isDown = false;
			}
		}

		public void MoveDown()
		{
			if (isUp)
			{
				upPosition = transform.position;
				downPosition = new Vector3(upPosition.x, upPosition.y - 0.3f, upPosition.z);

				transform.position = Vector3.Lerp(transform.position, downPosition, 0.3f);

				isUp = false;
				isDown = true;
			}
		}
	}
}
