﻿namespace BlogSystem.Web.ViewModels.Comment
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CommentViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        //public int BlogPostId { get; set; }

        public string UserId { get; set; } // Todo

        public string User { get; set; }

        public DateTime CommentedOn { get; set; } // CreatedOn

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(model => model.CommentedOn, config => config.MapFrom(comment => comment.CreatedOn));

            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(model => model.User, config => config.MapFrom(comment => comment.User.UserName));
        }
    }
}