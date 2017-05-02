// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31_ORDER (GroupMap) - 
    /// </summary>
    public class RSP_K31_ORDERMap :
        HL7TemplateMap<RSP_K31_ORDER>
    {
        public RSP_K31_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Group(x => x.OrderDetail, 2);
            Group(x => x.Encoding, 3);
            Segment(x => x.RXD, 4, x => x.Required = true);
            Segments(x => x.RXR, 5, x => x.Required = true);
            Segments(x => x.RXC, 6);
            Groups(x => x.Observation, 7, x => x.Required = true);
        }
    }
}