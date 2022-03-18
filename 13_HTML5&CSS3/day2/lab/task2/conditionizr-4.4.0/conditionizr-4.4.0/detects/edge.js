/**
 * Edge
 */
var testEdge = function()
{
    return /Edg/.test(navigator.userAgent);
}
conditionizr.add('edge', testEdge);
