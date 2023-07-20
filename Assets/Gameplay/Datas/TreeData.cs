using Gameplay.Placement;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Gameplay {

	[CreateAssetMenu(menuName = "�Զ�/��������")]
	public class TreeData:ScriptableObject {

		[field: SerializeField] public GameObject prefab { get; private set; }
		[field: SerializeField] public float growthTime { get; private set; }
		[field: SerializeField] public CULU.SerializedDictionary<TileData,float> survivalChance { get; private set; }
		[field: SerializeField] public int cost { get; private set; }
		[field: SerializeField] public float coverageContribution { get; private set; }
		[field: SerializeField] public float economics { get; private set; }

		[field: SerializeField] public int[] diseaseThreshold { get; private set; }
		[field: SerializeField] public bool diseaseSpread { get; private set; }
		[field: SerializeField] public float diseaseSpreadChance { get; private set; }
		[field: SerializeField] public float diseaseTime { get; private set; }

		TreePlacementCommand _command;
		public TreePlacementCommand command {
			get {
				if(_command==null) _command=TreePlacementCommand.GenerateCommand(this);
				return _command;
			}
		}

	}

}