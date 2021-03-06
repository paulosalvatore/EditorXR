﻿#if UNITY_EDITOR
using UnityEditor.Experimental.EditorVR.Modules;

namespace UnityEditor.Experimental.EditorVR.Core
{
    partial class EditorVR
    {
        class GazeDivergenceModuleConnector : Nested, ILateBindInterfaceMethods<GazeDivergenceModule>
        {
            public void LateBindInterfaceMethods(GazeDivergenceModule provider)
            {
                IDetectGazeDivergenceMethods.isAboveDivergenceThreshold = provider.IsAboveDivergenceThreshold;
            }
        }
    }
}
#endif
