using System;
using System.Collections;
using System.Collections.Generic;
using BloodOfEvil.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace BloodOfEvil.Utilities.UI
{
    /// <summary>
    /// Permet de changer la transparence de l'image en fonction de l'état de notre case à coché.
    /// </summary>
    [RequireComponent(typeof(Image))]
    public class ModifyImageTransparencToggleButton : AToggleButtonAction
    {
        #region Fields
        [SerializeField, Tooltip("C'est la transparence de l'image affichée lorsque l'état de notre case à coché est allumé.")]
        private float onAlpha;
        [SerializeField, Tooltip("C'est la transparence de l'image affichée lorsque l'état de notre case à coché est éteind.")]
        private float offAlpha;
        #endregion

        #region Override Behaviour
        protected override void ButtonToggleAction(bool isOn)
        {
            GetComponent<Image>().color = GetComponent<Image>().color.A(isOn ? this.onAlpha : this.offAlpha);
        }
        #endregion
    }
}
