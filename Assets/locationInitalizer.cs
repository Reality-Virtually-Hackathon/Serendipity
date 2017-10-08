using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mapbox.Unity.Map
{
	using Mapbox.Unity.Utilities;
	using Utils;
	using Mapbox.Map;


	public class locationInitalizer : MonoBehaviour {

		public AbstractMap map;
		public GameObject obj;
		Mapbox.Utils.Vector2d v;



		void Awake () {
			//obj.SetActive (false);
			map.enabled = false;
		}

		// Use this for initialization
		void Start () {
			int counter = 0;
			Input.location.Start ();
			while( v.x == 0 && v.y == 0 && counter < 1000){
			if (Input.location.isEnabledByUser) {
				v.x = Input.location.lastData.latitude;
				v.y = Input.location.lastData.longitude;
			} else {
				v.x = 40.44;
				v.y = 79.9959;
				}
				counter++;
			}
			map.SetCenterLatitudeLongitude (v);
			map.enabled = true;
			//obj.SetActive (true);

		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}
