﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_837PMap :
        X12LayoutMap<L2000B_837P, X12Entity>
    {
        public L2000B_837PMap()
        {
            Id = "2000B";
            Name = "Subscriber Heirarchical Level";
            
            Segment(x => x.SubscriberHeirarchicalLevel, 0, x => x.IsRequired());
            Segment(x => x.SubscriberInformtion, 1, x => x.IsRequired());
            Segment(x => x.PatientInformation, 2);
            Layout(x => x.Subscriber, 3);
            Layout(x => x.Payer, 4);
        }
    }
}