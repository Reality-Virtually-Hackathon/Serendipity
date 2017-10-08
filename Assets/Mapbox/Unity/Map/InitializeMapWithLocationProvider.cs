namespace Mapbox.Unity.Map
{
	using Mapbox.Unity.Location;
	using UnityEngine;

	public class InitializeMapWithLocationProvider : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

//		AbstractMap mappy;

		ILocationProvider _locationProvider;

		void Start()
		{
			_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider;
			_locationProvider.OnLocationUpdated += LocationProvider_OnLocationUpdated;
			Input.location.Start();

			Debug.Log (Input.location.isEnabledByUser);
			if (Input.location.isEnabledByUser) {
				Mapbox.Utils.Vector2d v = _map.CenterLatitudeLongitude;

				//			LocationInfo info = new LocationInfo ();
				v = new Mapbox.Utils.Vector2d (Input.location.lastData.altitude, Input.location.lastData.longitude);
				_map.SetCenterLatitudeLongitude (v);
			}

		}

		void LocationProvider_OnLocationUpdated(object sender, Location.LocationUpdatedEventArgs e)
		{
			_locationProvider.OnLocationUpdated -= LocationProvider_OnLocationUpdated;
			_map.Initialize(e.Location, _map.Zoom);
		}

		void Update (){

//			if (Input.GetKeyDown (KeyCode.A)) {
//				_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider;
//				_locationProvider.OnLocationUpdated += LocationProvider_OnLocationUpdated;
			}
//		}
	}
}