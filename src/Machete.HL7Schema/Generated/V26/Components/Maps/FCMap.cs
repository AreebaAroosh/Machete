// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FC (ComponentMap) - Financial Class
    /// </summary>
    public class FCMap :
        HL7ComponentMap<FC>
    {
        public FCMap()
        {
            Value(x => x.FinancialClassCode, 0);
            Value(x => x.EffectiveDate, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}