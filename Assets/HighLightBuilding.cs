using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mapbox.Unity.Map
{
using Mapbox.Unity.Utilities;
using Utils;
using Mapbox.Map;


public class HighLightBuilding : MonoBehaviour {

		public Mapbox.Utils.Vector2d v;
		public AbstractMap map;
		public Material highLightMat;


		void Start () {
			//v = new Mapbox.Utils.Vector2d (42.349279, -71.103347);
			Invoke ("HighLight", 2);

		}
		
		// Update is called once per frame
		void Update () {
 

		}

		void HighLight (){
			Vector3 origin = Conversions.GeoToWorldPosition (v, map.CenterMercator, map.WorldRelativeScale).ToVector3xz ();
			Debug.Log (Conversions.GeoToWorldPosition( v, map.CenterMercator, map.WorldRelativeScale).ToVector3xz());
			RaycastHit hit;
			Debug.DrawRay (origin + 10f * Vector3.up, Vector3.up, Color.blue, 10f);
			if (Physics.Raycast (origin + 100f * Vector3.up, -Vector3.up, out hit)) {
				Debug.Log (hit.collider.gameObject.name);
				int length = hit.collider.GetComponent<Renderer> ().materials.Length;
				Material[] mats = new Material[length];
				for (int i = 0; i < length; i++)
					mats [i] = highLightMat;
				hit.collider.GetComponent<Renderer> ().materials = mats;
				//hit.collider.gameObject.SetActive (false);
			}
//			if (Physics.Raycast (origin + 5f * Vector3.up, -Vector3.up, out hit)) {
//				Debug.Log ("hit something");
//				hit.collider.GetComponent<Renderer> ().material = highLightMat;
//				//hit.collider.gameObject.SetActive (false);
//			}

		}
	}
}