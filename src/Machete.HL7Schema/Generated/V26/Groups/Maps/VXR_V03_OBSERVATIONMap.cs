// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXR_V03_OBSERVATION (GroupMap) - 
    /// </summary>
    public class VXR_V03_OBSERVATIONMap :
        HL7TemplateMap<VXR_V03_OBSERVATION>
    {
        public VXR_V03_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}