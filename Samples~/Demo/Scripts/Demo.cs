using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KulibinSpace.HudPack.Demo {
    
	public class Demo : MonoBehaviour {

		public SimpleAltimeterWidget altimeter;

		void Update () {
			altimeter.heightValue = transform.position.y;
		}
	}

}

