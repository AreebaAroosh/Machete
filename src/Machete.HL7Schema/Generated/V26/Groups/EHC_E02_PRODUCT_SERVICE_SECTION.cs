// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E02_PRODUCT_SERVICE_SECTION (Group) - 
    /// </summary>
    public interface EHC_E02_PRODUCT_SERVICE_SECTION :
        HL7Template
    {
        /// <summary>
        /// PSS
        /// </summary>
        Segment<PSS> PSS { get; }

        /// <summary>
        /// PSG
        /// </summary>
        GroupList<EHC_E02_PSG> Psg { get; }
    }
}