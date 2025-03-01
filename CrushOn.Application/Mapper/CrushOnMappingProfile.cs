﻿using AutoMapper;
using CrushOn.Application.Commands;
using CrushOn.Application.Reponses;
using CrushOn.Core.EntitiesModel;

public class CrushOnMappingProfile : Profile
{
    public CrushOnMappingProfile()
    {
        CreateMap<SellerModel, SellerResponse>().ReverseMap();
        CreateMap<SellerModel, SellerCommand>().ReverseMap();

        CreateMap<ProductModel, ProductResponse>().ReverseMap();
        CreateMap<ProductModel, ProductCommand>().ReverseMap();

    }

}