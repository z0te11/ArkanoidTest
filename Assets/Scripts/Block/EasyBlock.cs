using UnityEngine;

namespace GAMEPLAY
{
    public class EasyBlock : Block, IInteract
    {
        public void InteractWithObject()
        {
            GetDamage();
        }
    }
}
