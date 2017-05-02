// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPP_PCB_PROBLEM (GroupMap) - 
    /// </summary>
    public class PPP_PCB_PROBLEMMap :
        HL7TemplateMap<PPP_PCB_PROBLEM>
    {
        public PPP_PCB_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.VAR, 2);
            Groups(x => x.ProblemRole, 3);
            Groups(x => x.ProblemObservation, 4);
            Groups(x => x.Goal, 5);
            Groups(x => x.Order, 6);
        }
    }
}