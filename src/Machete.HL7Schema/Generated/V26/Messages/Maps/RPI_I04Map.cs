// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPI_I04 (MessageMap) - 
    /// </summary>
    public class RPI_I04Map :
        HL7TemplateMap<RPI_I04>
    {
        public RPI_I04Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Groups(x => x.Provider, 4, x => x.Required = true);
            Segment(x => x.PID, 5, x => x.Required = true);
            Segments(x => x.NK1, 6);
            Group(x => x.GuarantorInsurance, 7);
            Segments(x => x.NTE, 8);
        }
    }
}