using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kulibin.Space {
	public class Demo : MonoBehaviour {

		public SimpleAltimeterWidget altimeter;

		void Update () {
			altimeter.heightValue = transform.position.y;
		}
	}

}

