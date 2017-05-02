// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_PATIENT (GroupMap) - 
    /// </summary>
    public class RGV_O15_PATIENTMap :
        HL7TemplateMap<RGV_O15_PATIENT>
    {
        public RGV_O15_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.AL1, 2);
            Group(x => x.PatientVisit, 3);
        }
    }
}