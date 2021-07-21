using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    // derives from the interface "Profile" in AutoMapper
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            // used to make a Camp Model from our Camp Entity
            CreateMap<Camp, CampModel>()
                // telling the mapper to give the model Venue data from the Entity
                .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName))
                .ReverseMap();
            CreateMap<Talk, TalkModel>();
            CreateMap<Speaker, SpeakerModel>();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(t => t.Speaker, opt => opt.Ignore())
                .ForMember(t => t.Camp, opt => opt.Ignore());

            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
    }
}