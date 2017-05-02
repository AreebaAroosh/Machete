// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MOP (ComponentMap) - Money or Percentage
    /// </summary>
    public class MOPMap :
        HL7ComponentMap<MOP>
    {
        public MOPMap()
        {
            Value(x => x.MoneyOrPercentageIndicator, 0);
            Value(x => x.MoneyOrPercentageQuantity, 1);
            Value(x => x.CurrencyDenomination, 2);
        }
    }
}