using AppSubription.Business.Abstraction.Models;
using Asom.Database.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSubscription.Business.Service.ObjectMapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<AppFeaturesModel, AppFeatures>().ReverseMap();
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<SubscriberModel, Subscriber>();
            CreateMap<SubscriptionModel, Subscription>().ReverseMap();
        }
    }
}
