using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour {
	public GameObject place;
	public int widthPlace;
	public int heightPlace;

	void Start () {
		CreateGround();
	}

	private void CreateGround()
	{
		float widthGround = 0;
		float heightGround = 0;

		Vector3 position = new Vector3(0, 0, 0);
		var worldManager = GameObject.FindGameObjectsWithTag("World Manager")[0];

		GameObject emptyParent = new GameObject("Ground");
		emptyParent.transform.position = position;

		for (int i = 1; i < widthPlace; i++)
		{
			for (int j = 0; j < heightPlace; j++)
			{
				heightGround += 1.5f;
				position = new Vector3(widthGround, 0, heightGround);

				Ground newGround = new Ground(i, j, place);

				worldManager.GetComponent<GroundManagerObject>().grounds.Add(newGround);

				var child = Instantiate(newGround.place, position, newGround.place.transform.rotation);
				child.transform.parent = emptyParent.transform;
			}

			heightGround = 0;
			widthGround += 1.5f;
		}
	}
}
