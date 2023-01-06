using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresentationLayer.ofDTOServices;
using FluentValidation;
using NMemory.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTOContext
{
    public class MarketDTOContext : DTOContext
    {
        public MarketDTOContext()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            base.OnServiceBuilder(serviceBuilder);
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
            base.OnStrorageBuilder(storageBuilder);
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde)
        {
            base.OnValidatorBuilder(validatorBuilde);
        }
    }
}
