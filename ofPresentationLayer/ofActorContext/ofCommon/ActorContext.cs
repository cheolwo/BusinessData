using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices;
using FluentValidation;
using NMemory.Tables;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class ActorOption
    {
        public bool IsUseStorage = false;
    }
    public class ActorContextAttribute : Attribute
    {
        private Type _actorContextType;
        public ActorContextAttribute(Type ActorContext)
        {
            _actorContextType = ActorContext;
        }
        public Type _ActorContextType
        {
            get => _actorContextType;
        }
    }
    public class BusinessContextAttribute : Attribute
    {
        private Type _OrdererContext;
        private Type _ForwarderContext;
        private Type _LogisterContext;
        private Type _SellerContext;
        private Type _ProducterContext;
        private Type _BusinessContext;
        public BusinessContextAttribute(Type businessContext)
        {
            _BusinessContext = businessContext;
        }
        public BusinessContextAttribute(Type ordererContext, Type forwarderContext, Type logisterContext, Type sellerContext, Type producterContext)
        {
            _OrdererContext = ordererContext;
            _ForwarderContext = forwarderContext;
            _LogisterContext = logisterContext;
            _SellerContext = sellerContext;
            _ProducterContext = producterContext;
        }
        public Type BusinessContext
        {
            get => _BusinessContext;
        }
        public Type OrdererContext
        {
            get => _OrdererContext;
        }
        public Type ForwarderContext
        {
            get => _ForwarderContext;
        }
        public Type LogisterContext
        {
            get => _LogisterContext;
        }
        public Type SellerContext
        {
            get => _SellerContext;
        }
        public Type ProducterContext
        {
            get => _ProducterContext;
        }
    }
    public class TradeContextAttribute : Attribute
    {
        private Type _ordererContextType;
        private Type _producterContextType;
        public TradeContextAttribute(Type OrdererContext, Type ProducterContext)
        {
            _ordererContextType = OrdererContext;
            _producterContextType = ProducterContext;
        }
        public Type _OrdererContextType
        {
            get => _ordererContextType;
        }
        public Type _ProducterContextType
        {
            get => _producterContextType;
        }
    }

    // Get 및 Gets는 관련 데이터까지 로드하는 것을 의미한다.

    public abstract class ActorContext
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        public ActorContext()
        {
            OnServiceBuilder(ServiceBuilder);
            OnValidatorBuilder(ValidatorBuilder);
            OnStrorageBuilder(StorageBuilder);
        }
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }
        public abstract Task<T> PostAsync<T>(T t, MultipartFormDataContent content) where T : EntityDTO, new();
        public abstract Task<T> PostAsync<T>(T t) where T : EntityDTO, new();
        public abstract Task<T> PutAsync<T>(T t) where T : EntityDTO, new();
        public abstract Task<T> GetByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task DeleteByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : EntityDTO, new();
        public abstract IValidator<T> GetValidator<T>() where T : EntityDTO, new();
        public abstract ITable<T> GetMemoryTable<T>() where T : EntityDTO, new();
        public abstract DTOService GetDTOService<T>() where T : EntityDTO, new();
    }
}
