using UnityEngine;

namespace Object
{
    public class CloseButton : MonoBehaviour
    {
        private ICloseObject objects;

        private void Awake()
        {
            objects = GetComponentInParent<ICloseObject>();
        }

        public void OnClickClose()
        {
            objects.CloseObject();
        }
    }
}
