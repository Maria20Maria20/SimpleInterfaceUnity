using UnityEngine;

namespace Object
{
    public class ObjectScript : MonoBehaviour, ICloseObject
    {
        public void CloseObject()
        {
            gameObject.SetActive(false);
        }

    }
}
