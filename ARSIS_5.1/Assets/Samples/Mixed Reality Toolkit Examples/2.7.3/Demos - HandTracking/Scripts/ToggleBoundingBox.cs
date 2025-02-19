﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [System.Obsolete("This component is no longer supported", true)]
    [AddComponentMenu("Scripts/MRTK/Obsolete/ToggleBoundingBox")]
    public class ToggleBoundingBox : MonoBehaviour
    {
        public BoundingBox boundingBox;

        private void Awake()
        {
            Debug.LogError(this.GetType().Name + " is deprecated");
        }

        public void ToggleBoundingBoxActiveState()
        {
            // Do something on specified distance for fire event
            if (boundingBox != null)
            {
                //boundingBox.Active = !boundingBox.Active;
            }

        }
    }
}