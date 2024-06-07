using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace MikeNspired.UnityXRHandPoser
{
    /// <summary>
    /// Socket interactor that only selects and hovers interactables with a keychain component containing specific keys
    /// </summary>
    public class XRClosedSocketInteractor : XRSocketInteractor
    {
        [SerializeField]
        [Tooltip("The required keys to interact with this socket")]
        Lock m_Lock;

        /// <inheritdoc />
        public override bool CanHover(IXRHoverInteractable interactable)
        {
            if (!base.CanHover(interactable))
                return false;

            var keyChain = interactable.transform.GetComponent<IKeychain>();
            return m_Lock.CanUnlock(keyChain);
        }

        /// <inheritdoc />
        public override bool CanSelect(IXRSelectInteractable interactable)
        {
            if (!base.CanSelect(interactable))
                return false;

            var keyChain = interactable.transform.GetComponent<IKeychain>();
            return m_Lock.CanUnlock(keyChain);
        }
    }
}
