using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay {

	[CreateAssetMenu(menuName = "�Զ�/��������")]
	public class TileData:ScriptableObject {

		[field: SerializeField] public GameObject prefab { get; private set; }
		[field: SerializeField] public List<TileData> canPlaceOn { get; private set; }
		[field: SerializeField] public int cost { get; private set; }

	}

}