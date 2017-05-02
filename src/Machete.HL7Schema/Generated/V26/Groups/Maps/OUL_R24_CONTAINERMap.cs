// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R24_CONTAINER (GroupMap) - 
    /// </summary>
    public class OUL_R24_CONTAINERMap :
        HL7TemplateMap<OUL_R24_CONTAINER>
    {
        public OUL_R24_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Segment(x => x.INV, 1);
        }
    }
}