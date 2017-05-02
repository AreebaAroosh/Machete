// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O33_PATIENT (GroupMap) - 
    /// </summary>
    public class OML_O33_PATIENTMap :
        HL7TemplateMap<OML_O33_PATIENT>
    {
        public OML_O33_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segments(x => x.NTE, 2);
            Segments(x => x.NK1, 3);
            Group(x => x.PatientVisit, 4);
            Groups(x => x.Insurance, 5);
            Segment(x => x.GT1, 6);
            Segments(x => x.AL1, 7);
        }
    }
}