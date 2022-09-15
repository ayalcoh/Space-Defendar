using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class getTargetInfo
{
    //get if target is in range, will return true..providing position, direction, range and layer mask for the ray
    public static bool getTargetRange(Vector3 Rposition, Vector3 rayDirection, out RaycastHit HitInfo, float range, LayerMask rangeMask)
    {
        return (Physics.Raycast(Rposition, rayDirection, out HitInfo, range, rangeMask));// HitInfo == what target we hit.
    }
}
